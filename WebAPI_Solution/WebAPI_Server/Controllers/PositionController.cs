using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DiplomsClassLibrary.Models;
using WebAPI_Server.Data;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI_Solution.Controllers
{
	//[Authorize]
	[ApiController]
	[Route("[controller]")]
	public class PositionController : ControllerBase
	{
		private readonly DiplomsDbContext _dbContext;
		public PositionController(DiplomsDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpPost]
		public IEnumerable<Position> Get(Position filter)
		{
			var name = filter.Name?.ToLower();
			var query = _dbContext.Positions.AsQueryable();
			if (!string.IsNullOrEmpty(name)) query = query.Where(x => x.Name.ToLower().Contains(name));
			return query.ToList();
		}

		[HttpGet("{id}")]
		public Position Get(int id)
		{
			return _dbContext.Positions.FirstOrDefault(x => x.Id == id);
		}

		[HttpPost("{id}")]
		public IActionResult Post(int id, Position position)
		{
			Position existingPosition = _dbContext.Positions.Find(id);

			if (existingPosition == null) return NotFound();
			existingPosition.Name = position.Name;

			_dbContext.Positions.Update(existingPosition);
			_dbContext.SaveChanges();

			return Ok();
		}

		[HttpPut]
		public IActionResult Put(Position position)
		{
			if (position == null) return BadRequest();
			_dbContext.Positions.Add(position);
			_dbContext.SaveChanges();
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			Position position = _dbContext.Positions.Find(id);
			if (position == null) return NotFound();
			_dbContext.Positions.Remove(position);
			_dbContext.SaveChanges();
			return Ok();
		}

	}
}
