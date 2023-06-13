using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DiplomsClassLibrary.Models;
using DiplomsClassLibrary.Dto;
using WebAPI_Server.Data;
using System.Linq;
using System;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using WebAPI_Server.Models;

namespace WebAPI_Solution.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AuthController : ControllerBase
	{
		private readonly DiplomsDbContext _dbContext;
		public AuthController(DiplomsDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpPost("[action]")]
		public string Register(LoginDto data)
		{
			if (_dbContext.Users.Any(x => x.Login == data.Login)) return null;
			var user = new User() { Login = data.Login, EncryptedPass = data.Password }; //типа закодировали
			_dbContext.Users.Add(user);
			_dbContext.SaveChanges();
			return GetToken(user);
		}


		[HttpPost("[action]")]
		public string Login(LoginDto data)
		{
			var user = _dbContext.Users.FirstOrDefault(x => x.Login == data.Login && x.EncryptedPass == data.Password); //типа закодированный
			return user == null ? null : GetToken(user);
		}


		private string GetToken(User user)
		{
			var identity = GetIdentity(user);

			var now = DateTime.UtcNow;
			// создаем JWT-токен
			var jwt = new JwtSecurityToken(
					issuer: AuthOptions.ISSUER,
					audience: AuthOptions.AUDIENCE,
					notBefore: now,
					claims: identity.Claims,
					expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
					signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
			var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

			return encodedJwt;
		}

		private ClaimsIdentity GetIdentity(User user)
		{
			if (user != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
					new Claim("Id", user.Id.ToString()),
				};
				ClaimsIdentity claimsIdentity =
				new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
					ClaimsIdentity.DefaultRoleClaimType);
				return claimsIdentity;
			}

			// если пользователя не найдено
			return null;
		}


	}
}
