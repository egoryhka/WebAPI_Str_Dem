using DiplomsClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Client.Services;

namespace WebAPI_Client.Controllers
{
    public class DirectionController : Controller
    {
        private readonly DiplomCatalogService _diplomCatalogService;

        public DirectionController(DiplomCatalogService diplomCatalogService)
        {
            _diplomCatalogService = diplomCatalogService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var directions = await _diplomCatalogService.GetDirections();
            return View(directions);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Direction());
        }

        [HttpPost]
        public async Task<IActionResult> Add(Direction direction)
        {
            var newDirection = await _diplomCatalogService.AddDirection(direction);
            if (newDirection) return RedirectToAction(nameof(Get));
            return View(direction);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editingDirection = await _diplomCatalogService.GetDirection(id);
            if (editingDirection == null) return NotFound();
            return View(editingDirection);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Direction direction)
        {
            if (ModelState.IsValid)
            {
                var editingDirection = await _diplomCatalogService.EditDirection(direction);
                if (editingDirection) return RedirectToAction(nameof(Get));

                return View(editingDirection);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            await _diplomCatalogService.RemoveDirection(id);
            return RedirectToAction(nameof(Get));
        }

    }
}
