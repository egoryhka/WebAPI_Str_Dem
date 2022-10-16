using DiplomsClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
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
            ViewBag.AuthorsExists = (await GetAuthors()) != null;
            return View(diploms);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var authors = await GetAuthors();
            var directions = await GetDirections();
            if (authors == null || directions == null) return BadRequest();

            return View(new Diplom_Authors_Directions()
            {
                Diplom = new Diplom() { Release = DateTime.Now },
                Authors = new SelectList(authors, "Id", "FIO"),
                Directions = new SelectList(directions, "Id", "Name")
            });
        }

        [HttpPost]
        public async Task<IActionResult> Add(Diplom_Authors_Directions model)
        {
            var authors = await GetAuthors();
            var directions = await GetDirections();
            if (authors == null || directions == null) return BadRequest();

            model.Authors = new SelectList(authors, "Id", "FIO", model.Diplom.AuthorId);
            model.Directions = new SelectList(directions, "Id", "Name", model.Diplom.DirectionId);

            var newDiplom = await _diplomCatalogService.AddDiplom(model.Diplom);
            if (newDiplom) return RedirectToAction(nameof(Get));
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var authors = await GetAuthors();
            var directions = await GetDirections();
            if (authors == null || directions == null) return BadRequest();

            var editingDiplom = await _diplomCatalogService.GetDiplom(id);
            if (editingDiplom == null) return NotFound();
            return View(new Diplom_Authors_Directions()
            {
                Diplom = editingDiplom,
                Authors = new SelectList(authors, "Id", "FIO", editingDiplom.AuthorId),
                Directions = new SelectList(directions, "Id", "Name", editingDiplom.DirectionId)
            });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Diplom_Authors_Directions model)
        {
            if (ModelState.IsValid)
            {
                var authors = await GetAuthors();
                var directions = await GetDirections();
                if (authors == null || directions == null) return BadRequest();

                model.Authors = new SelectList(authors, "Id", "FIO", model.Diplom.AuthorId);
                model.Directions = new SelectList(directions, "Id", "Name", model.Diplom.DirectionId);

                var editingDiplom = await _diplomCatalogService.EditDiplom(model.Diplom);
                if (editingDiplom) return RedirectToAction(nameof(Get));

                return View(model);
            }
            return BadRequest();
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


        public class Diplom_Authors_Directions
        {
            public Diplom_Authors_Directions() { }
            public Diplom Diplom { get; set; }
            public SelectList Authors { get; set; }
            public SelectList Directions { get; set; }

        }
    }
}
