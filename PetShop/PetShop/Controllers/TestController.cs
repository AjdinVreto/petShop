using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController
    {
        public static List<Test> _test;
        static TestController()
        {
            _test = new List<Test>
            {
                new Test
                {
                    Id = 1,
                    Naziv = "A"
                },
                new Test
                {
                    Id = 2,
                    Naziv = "B"
                }
            };
        }

        [HttpGet]
        public List<Test> Get()
        { 

            return _test;
        }
    }

    public class Test
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
