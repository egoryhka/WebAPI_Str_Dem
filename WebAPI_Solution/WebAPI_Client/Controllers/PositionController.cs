using DiplomsClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Client.Services;

namespace WebAPI_Client.Controllers
{
    public class PositionController : Controller
    {
        private readonly DiplomCatalogService _diplomCatalogService;

        public PositionController(DiplomCatalogService diplomCatalogService)
        {
            _diplomCatalogService = diplomCatalogService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var positions = await _diplomCatalogService.GetPositions();
            return View(positions);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Position());
        }

        [HttpPost]
        public async Task<IActionResult> Add(Position position)
        {
            var newPosition = await _diplomCatalogService.AddPosition(position);
            if (newPosition) return RedirectToAction(nameof(Get));
            return View(position);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editingPosition = await _diplomCatalogService.GetPosition(id);
            if (editingPosition == null) return NotFound();
            return View(editingPosition);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Position position)
        {
            if (ModelState.IsValid)
            {
                var editingPosition = await _diplomCatalogService.EditPosition(position);
                if (editingPosition) return RedirectToAction(nameof(Get));

                return View(editingPosition);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            await _diplomCatalogService.RemovePosition(id);
            return RedirectToAction(nameof(Get));
        }

    }
}
