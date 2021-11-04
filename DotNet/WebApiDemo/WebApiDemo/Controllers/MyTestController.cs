using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTestController : ControllerBase
    {
        public string Hello()
        {
            return "Hello World!";
        }
    }
}
