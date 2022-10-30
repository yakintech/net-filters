using System;
using Microsoft.AspNetCore.Mvc;
using NetActionFilters.Models;

namespace NetActionFilters.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        [ResponseHeader("name","cagatay")]
        public IActionResult Get()
        {
            var categories = new List<CategoryDto>()
            {
                new CategoryDto(){Id = 1, Name = "Electronic"},
                new CategoryDto(){Id = 2, Name = "Sport"},
            };

            return Ok(categories);
        }


    }
}

