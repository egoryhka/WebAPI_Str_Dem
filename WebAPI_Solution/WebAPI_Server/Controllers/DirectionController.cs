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
    public class DirectionController : ControllerBase
    {
        private readonly DiplomsDbContext _dbContext;
        public DirectionController(DiplomsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IEnumerable<Direction> Get(Direction filter)
        {
			var name = filter.Name?.ToLower();
			var query = _dbContext.Directions.AsQueryable();
			if (!string.IsNullOrEmpty(name)) query = query.Where(x => x.Name.ToLower().Contains(name));
			return query.ToList();
		}

        [HttpGet("{id}")]
        public Direction Get(int id)
        {
            return _dbContext.Directions.FirstOrDefault(x => x.Id == id);
        }

		[HttpPost("{id}")]
        public IActionResult Post(int id, Direction direction)
        {
            Direction existingDirection = _dbContext.Directions.Find(id);

            if (existingDirection == null) return NotFound();
            existingDirection.Name = direction.Name;

            _dbContext.Directions.Update(existingDirection);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Direction direction)
        {
            if (direction == null) return BadRequest();
            _dbContext.Directions.Add(direction);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Direction direction = _dbContext.Directions.Find(id);
            if (direction == null) return NotFound();
            _dbContext.Directions.Remove(direction);
            _dbContext.SaveChanges();
            return Ok();
        }

    }
}
