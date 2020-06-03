using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace KatasAPI.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{explosions}")]

        public string Explosions(string explosion)
        {
            var answer = "";

            foreach (var character in explosion)
            {
                var number = int.Parse(character.ToString());

                for (var n = 0; n < number; n++)
                {
                    answer = answer + character;
                }
            }
            return answer;
        }
    }
}
