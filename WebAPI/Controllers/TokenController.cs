using WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly PersonContext _context;

        public TokenController(IConfiguration config, PersonContext context)
        {
            _configuration = config;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(LoginModel _userData)
        {

            if (_userData != null && _userData.Username != null && _userData.Password != null)
            {
                IActionResult response = Unauthorized();
                var user = await GetUser(_userData.Username, _userData.Password);

                if (user != null)
                {
                   var tokenString =  BuildToken(user);
                   response = Ok(new { token = tokenString });

                    return response;
                } 
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        //Builds the token
        private string BuildToken(Person user)
        {
            var claims = new[] {
            new Claim(JwtRegisteredClaimNames.Sub, user.FirstName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
            new Claim("Id", user.PersonID.ToString()),
            new Claim("Lastname", user.LastName),
            new Claim("Username", user.Username),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        //Finds Person object based on username and password
        private async Task<Person> GetUser(string username, string password)
        {
            return await _context.Persons.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }
    }
}