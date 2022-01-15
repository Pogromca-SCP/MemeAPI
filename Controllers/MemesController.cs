using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using MemeAPI.Models;
using System;

namespace MemeAPI.Controllers
{
    /// <summary>
    /// Handles meme requests
    /// </summary>
    [ApiController]
    [Route("api")]
    public class MemesController : ControllerBase
    {
        /// <summary>
        /// Contains all memes
        /// </summary>
        private static readonly Meme[] memes = new[] {
            new Meme{ Title = "", Link = ""},
            new Meme{ Title = "", Link = ""},
            new Meme{ Title = "", Link = ""},
            new Meme{ Title = "", Link = ""},
            new Meme{ Title = "", Link = ""},
            new Meme{ Title = "", Link = ""},
            new Meme{ Title = "", Link = ""}
        };

        private readonly ILogger<MemesController> _logger;

        public MemesController(ILogger<MemesController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Standard meme request
        /// </summary>
        /// <returns>All of the memes</returns>
        [HttpGet()]
        public IActionResult GetMemes()
        {
            return Ok(memes);
        }

        /// <summary>
        /// Random meme request
        /// </summary>
        /// <returns>Random meme</returns>
        [HttpGet("random")]
        public IActionResult GetRandomMeme()
        {
            var index = new Random().Next(0, memes.Length - 1);
            return Ok(memes[index]);
        }
    }
}