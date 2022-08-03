using name_api.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace name_api.Controllers
{
    [ApiController]
    [Route("/name/api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IAuthorizationService _authorizationService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration, IAuthorizationService authorizationService)
        {
            _logger = logger;
            _configuration = configuration;
            _authorizationService = authorizationService;
        }

        [HttpPost]
        [Route("[action]")]
        [Authorize(Policy = "PolicyAdmin")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        [Route("[action]")]
        [Authorize(Policy = "PolicyAdmin1")]
        public IEnumerable<WeatherForecast> Get1([FromBody] AuthenTestModel User)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        [Route("[action]")]
        [AllowAnonymous]
        public ActionResult<String> Login([FromBody] AuthenTestModel User)
        {
            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, User.Username),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.Role, "User"),
                    new Claim(ClaimTypes.Role, "ContactAdministrators"),
                    new Claim("type", "AdminType"),
                };

            //foreach (var userRole in userRoles)
            //{
            //    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            //}

            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var Token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                expires: DateTime.Now.AddDays(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(Key, SecurityAlgorithms.HmacSha256)
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(Token),
                expiration = Token.ValidTo
            });
        }
        [HttpPost]
        [Route("[action]")]
        [AllowAnonymous]
        public ActionResult<String> Login1([FromBody] AuthenTestModel User)
        {
            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, User.Username),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.Role, "Admin"),
                };

            //foreach (var userRole in userRoles)
            //{
            //    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            //}

            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var Token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                expires: DateTime.Now.AddDays(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(Key, SecurityAlgorithms.HmacSha256)
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(Token),
                expiration = Token.ValidTo
            });
        }
        [HttpPost]
        [Route("[action]")]
        [AllowAnonymous]
        public ActionResult<String> Login2([FromBody] AuthenTestModel User)
        {
            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, User.Username),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.Role, "ContactAdministrators"),
                };

            //foreach (var userRole in userRoles)
            //{
            //    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            //}

            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var Token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                expires: DateTime.Now.AddDays(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(Key, SecurityAlgorithms.HmacSha256)
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(Token),
                expiration = Token.ValidTo
            });
        }
    }
}
