using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public object SayHello(HelloData data)
        {
            // example of adding a new row to the SQL database
            NorthwindContext context = new();
            Category category = new()
            {
                CategoryName = data.Username,
                Description = "Shoe number: " + data.Shoenumber
            };
            context.Categories.Add(category);
            context.SaveChanges();

            // return JSON data to the caller
            return new
            {
                Text = $"Hello {data.Username} from C#!"
            };
        }
    }
}
