using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wasm.Shared;

namespace wasm.Server.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController
    {
        public QuestionsController()
        {
        }

        [HttpGet]
        public async Task<IActionResult> Posts()
        {
            var posts = new List<Post>
            {
                new Post()
                {
                     Title = "First",
                     Content = "My First Question"
                },
                new Post()
                {
                     Title = "Second",
                     Content = "My 2nd Question"
                },
                new Post()
                {
                     Title = "3rd",
                     Content = "My 3rd Question"
                },
            };

            return await Task.FromResult(new JsonResult(posts));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var post = new Post()
            {
                Id = id,
                Content = "Testowe body",
                CreationDate = DateTime.Now.AddYears(-1),
                Title = "BEST POST"
            };

            return await Task.FromResult(new JsonResult(post));
        }
    }
}
