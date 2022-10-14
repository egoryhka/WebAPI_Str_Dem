using DiplomsClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_Client.Services;

namespace WebAPI_Client.Controllers
{
    public class DiplomController : Controller
    {
        private readonly DiplomCatalogService _diplomCatalogService;

        public DiplomController(DiplomCatalogService diplomCatalogService)
        {
            _diplomCatalogService = diplomCatalogService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var diploms = await _diplomCatalogService.GetDiploms();
            return View(diploms);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Diplom diplom)
        {
            var newDiplom = await _diplomCatalogService.AddDiplom(diplom);
            if (newDiplom) return RedirectToAction(nameof(Get));
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editingDiplom = await _diplomCatalogService.GetDiplom(id);
            if (editingDiplom == null) return NotFound();
            return View((
                editingDiplom,
                new SelectList(await GetAuthors() ?? new Author[0], "Id", "FIO", editingDiplom.AuthorId),
                new SelectList(await GetDirections() ?? new Direction[0], "Id", "Name", editingDiplom.DirectionId)));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Diplom diplom)
        {
            var editingDiplom = await _diplomCatalogService.EditDiplom(diplom);
            if (editingDiplom) return RedirectToAction(nameof(Get));
            return View((
              diplom,
              new SelectList(await GetAuthors() ?? new Author[0], "Id", "FIO", diplom.AuthorId),
              new SelectList(await GetDirections() ?? new Direction[0], "Id", "Name", diplom.DirectionId)));
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            await _diplomCatalogService.RemoveDiplom(id);
            return RedirectToAction(nameof(Get));
        }

        // Для селектов
        private async Task<IEnumerable<Author>> GetAuthors() => await _diplomCatalogService.GetAuthors();
        private async Task<IEnumerable<Direction>> GetDirections() => await _diplomCatalogService.GetDirections();

    }
}
