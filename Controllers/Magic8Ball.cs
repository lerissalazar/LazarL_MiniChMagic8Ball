//lerissa lazar
//10-27-22
//magic 8 ball
//insert a question into the computer and it will output a random answer
//peer review Jovann contreras: Code is very intresting when running it it debugs and gives no error. URL works in postman and I am able to type in a question and be given a random answer. Everytime I refresh it gives me a random question everytime so thats good!

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarL_MiniChMagic8Ball.Controllers
{
    [Route("[controller]")]
    public class Magic8Ball : Controller
    {
        [HttpGet]
        [Route("Magic/{input}")]
        public string Magic8(string input)
        {
            Random rand = new Random();
            int index = rand.Next(1, 9);
            switch (index)
            {
                case 1:
                    return $"All signs point to yes";
                    break;
                case 2:
                    return $"Absolutely";
                    break;
                case 3:
                    return $"Outlook looks good";
                    break;
                case 4:
                    return $"Cannot predict now";
                    break;
                case 5:
                    return $"Ask again later";
                    break;
                case 6:
                    return $"My reply is no";
                    break;
                case 7:
                    return $"My sources say no";
                    break;
                case 8:
                    return $"Dont count on it";
                    break;
            }
            return "error";
        }
    }
}