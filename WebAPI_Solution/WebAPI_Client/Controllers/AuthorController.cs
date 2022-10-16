using DiplomsClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Client.Services;

namespace WebAPI_Client.Controllers
{
    public class AuthorController : Controller
    {
        private readonly DiplomCatalogService _diplomCatalogService;

        public AuthorController(DiplomCatalogService diplomCatalogService)
        {
            _diplomCatalogService = diplomCatalogService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var authors = await _diplomCatalogService.GetAuthors();
            ViewBag.PositionsExists = (await GetPositions()) != null;

            return View(authors);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var positions = await GetPositions();
            if (positions == null) return BadRequest();

            return View(new AuthorAndPositions()
            {
                Author = new Author(),
                Positions = new SelectList(positions, "Id", "Name")
            });
        }

        [HttpPost]
        public async Task<IActionResult> Add(AuthorAndPositions model)
        {
            var positions = await GetPositions();
            if (positions == null) return BadRequest();

            model.Positions = new SelectList(positions, "Id", "Name", model.Author.PositionId);
            var newAuthor = await _diplomCatalogService.AddAuthor(model.Author);
            if (newAuthor) return RedirectToAction(nameof(Get));
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var positions = await GetPositions();
            if (positions == null) return BadRequest();

            var editingAuthor = await _diplomCatalogService.GetAuthor(id);
            if (editingAuthor == null) return NotFound();
            return View(new AuthorAndPositions()
            {
                Author = editingAuthor,
                Positions = new SelectList(positions, "Id", "Name", editingAuthor.PositionId)
            });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AuthorAndPositions model)
        {
            if (ModelState.IsValid)
            {
                var positions = await GetPositions();
                if (positions == null) return BadRequest();

                model.Positions = new SelectList(positions, "Id", "Name", model.Author.PositionId);

                var editingAuthor = await _diplomCatalogService.EditAuthor(model.Author);
                if (editingAuthor) return RedirectToAction(nameof(Get));

                return View(model);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            await _diplomCatalogService.RemoveAuthor(id);
            return RedirectToAction(nameof(Get));
        }

        // Для селектов
        private async Task<IEnumerable<Position>> GetPositions() => await _diplomCatalogService.GetPositions();

        public class AuthorAndPositions
        {
            public AuthorAndPositions() { }
            public Author Author { get; set; }
            public SelectList Positions { get; set; }

        }
    }
}
