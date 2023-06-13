using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DiplomsClassLibrary.Models;
using DiplomsClassLibrary.Dto;
using WebAPI_Server.Data;
using System.Linq;
using System;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI_Solution.Controllers
{
	[Authorize]
	[ApiController]
	[Route("[controller]")]
	public class ServiceController : ControllerBase
	{
		private readonly DiplomsDbContext _dbContext;
		public ServiceController(DiplomsDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpGet("[action]")]
		public IActionResult GetUser()
		{
			var user = _dbContext.Users.FirstOrDefault(x => x.Login == User.Identity.Name);
			return new JsonResult(user != null ? new { user.Login, user.Id } : null);
		}

		[HttpGet("[action]")]
		public IEnumerable<SelectDto> AcademicDegreeSelect()
		{
			return Enum.GetValues<AcademicDegree>().Select(x => new SelectDto { Value = (int)x, Label = x.DescriptionAttr() });
		}

		[HttpGet("[action]")]
		public IEnumerable<SelectDto> PositionSelect()
		{
			return _dbContext.Positions.Select(x => new SelectDto { Value = x.Id, Label = x.Name });
		}

		[HttpGet("[action]")]
		public IEnumerable<SelectDto> DirectionSelect()
		{
			return _dbContext.Directions.Select(x => new SelectDto { Value = x.Id, Label = x.Name });
		}

		[HttpGet("[action]")]
		public IEnumerable<SelectDto> AuthorSelect()
		{
			return _dbContext.Authors.Select(x => new SelectDto { Value = x.Id, Label = x.ShortFIO });
		}


	}
}
