using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DiplomsClassLibrary.Models;
using WebAPI_Server.Data;
using System.Linq;

namespace WebAPI_Solution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiplomController : ControllerBase
    {
        private readonly DiplomsDbContext _dbContext;
        public DiplomController(DiplomsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Diplom> Get()
        {
            return _dbContext.Diploms;
        }

        [HttpGet("{id}")]
        public Diplom Get(int id)
        {
            return _dbContext.Diploms.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost("{id}")]
        public IActionResult Post(int id, Diplom diplom)
        {
            Diplom existingDiplom = _dbContext.Diploms.Find(id);

            if (existingDiplom == null) return NotFound();

            existingDiplom.AuthorId = diplom.AuthorId;
            existingDiplom.AcademicDegree = diplom.AcademicDegree;
            existingDiplom.DirectionId = diplom.DirectionId;
            existingDiplom.HeadName = diplom.HeadName;
            existingDiplom.Title = diplom.Title;
            existingDiplom.Release = diplom.Release;

            _dbContext.Diploms.Update(existingDiplom);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Diplom diplom)
        {
            if (diplom == null) return BadRequest();
            _dbContext.Diploms.Add(diplom);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Diplom diplom = _dbContext.Diploms.Find(id);
            if (diplom == null) return NotFound();
            _dbContext.Diploms.Remove(diplom);
            _dbContext.SaveChanges();
            return Ok();
        }

    }
}
