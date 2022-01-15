using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using MemeAPI.Models;
using System;
using Microsoft.AspNetCore.Cors;

namespace MemeAPI.Controllers
{
    /// <summary>
    /// Handles meme requests
    /// </summary>
    [ApiController]
    [Route("api")]
    [EnableCors("MemePolicy")]
    public class MemesController : ControllerBase
    {
        /// <summary>
        /// Contains all memes
        /// </summary>
        private static readonly Meme[] memes = new[] {
            new Meme{ Title = "Shrek", Link = "https://i.pinimg.com/736x/4c/19/6b/4c196b5842f472716f137b767f52bf52.jpg"},
            new Meme{ Title = "Stonks", Link = "https://img.wprost.pl/_thumb/95/8c/aa8907487224544857a91f0de4fa.jpeg"},
            new Meme{ Title = "Toy Story", Link = "https://cdn.vox-cdn.com/thumbor/nr3KfqoS4dGCLfEo6CEwovrnays=/1400x1050/filters:format(png)/cdn.vox-cdn.com/uploads/chorus_asset/file/19933026/image.png"},
            new Meme{ Title = "Unlimited Power", Link = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRLE5T60tHbSZn7BQZDZseb5wkGUfWW4hl1Og&usqp=CAU"},
            new Meme{ Title = "WTF", Link = "https://blog.hubspot.com/hubfs/how-to-make-a-meme.jpg"},
            new Meme{ Title = "Mercy - Penguin", Link = "https://preview.redd.it/fl49jyyyfn581.jpg?auto=webp&s=c605accdf0275d8255cb11db05dd665f2f157fae"},
            new Meme{ Title = "TF2 Soldier", Link = "https://i.imgflip.com/3sit8k.jpg"},
            new Meme{ Title = "Ricardo", Link = "https://img-9gag-fun.9cache.com/photo/aD46XL9_460s.jpg" }
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