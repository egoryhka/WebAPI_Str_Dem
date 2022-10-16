using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DiplomsClassLibrary.Models;
using WebAPI_Server.Data;
using System.Linq;

namespace WebAPI_Solution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly DiplomsDbContext _dbContext;
        public AuthorController(DiplomsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return _dbContext.Authors;
        }

        [HttpGet("{id}")]
        public Author Get(int id)
        {
            return _dbContext.Authors.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost("{id}")]
        public IActionResult Post(int id, Author author)
        {
            Author existingAuthor = _dbContext.Authors.Find(id);

            if (existingAuthor == null) return NotFound();

            existingAuthor.AcademicDegree = author.AcademicDegree;
            existingAuthor.FirstName = author.FirstName;
            existingAuthor.SecondName = author.SecondName;
            existingAuthor.ThirdName = author.ThirdName;
            existingAuthor.PositionId = author.PositionId;

            _dbContext.Authors.Update(existingAuthor);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Author author)
        {
            if (author == null) return BadRequest();
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Author author = _dbContext.Authors.Find(id);
            if (author == null) return NotFound();
            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();
            return Ok();
        }

    }
}
