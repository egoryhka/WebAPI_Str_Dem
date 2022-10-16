using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DiplomsClassLibrary.Models;
using WebAPI_Server.Data;
using System.Linq;

namespace WebAPI_Solution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PositionController : ControllerBase
    {
        private readonly DiplomsDbContext _dbContext;
        public PositionController(DiplomsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Position> Get()
        {
            return _dbContext.Positions;
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
