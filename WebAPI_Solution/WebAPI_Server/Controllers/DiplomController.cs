using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DiplomsClassLibrary.Models;
using WebAPI_Server.Data;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Collections;

namespace WebAPI_Solution.Controllers
{
	[Authorize]
	[ApiController]
    [Route("[controller]")]
    public class DiplomController : ControllerBase
    {
        private readonly DiplomsDbContext _dbContext;
        public DiplomController(DiplomsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IEnumerable<Diplom> Get(Diplom filter)
        {
			var title = filter.Title?.ToLower();
			var headName = filter.HeadName?.ToLower();

			var query = _dbContext.Diploms.AsQueryable();
            if (!string.IsNullOrEmpty(title)) query = query.Where(x => x.Title.ToLower().Contains(title));
			if (!string.IsNullOrEmpty(headName)) query = query.Where(x => x.HeadName.ToLower().Contains(headName));
            if (filter.DirectionId != null) query = query.Where(x => x.DirectionId == filter.DirectionId);

			return query.ToList();
        }

		[HttpGet("[action]")]
		public IEnumerable GetDiplomsDistribution()
		{
			return _dbContext.Diploms.GroupBy(x => x.Direction.Name).Select(x => new { Name = x.Key, Value = x.Count() });
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

		[HttpPost("[action]/{id}")]
		public IActionResult Duplicate(int id)
		{
			Diplom diplom = _dbContext.Diploms.Find(id);
			if (diplom == null) return NotFound();
			var copy = diplom.Copy();
			_dbContext.Diploms.Add(copy);
			_dbContext.SaveChanges();
			return Ok();
		}


	}
}
