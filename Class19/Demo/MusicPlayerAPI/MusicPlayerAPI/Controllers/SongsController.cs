using Microsoft.AspNetCore.Mvc;
using MusicPlayerAPI.Data;
using MusicPlayerAPI.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private MusicDbContext _context;

        public SongsController(MusicDbContext context)
        {
            _context = context;
        }

        // Get

        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _context.Songs;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Song song = _context.Songs.FirstOrDefault(s => s.ID == id);
            if (song == null)
            {
                return NotFound();
            }

            return Ok(song);
        }

        // Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Song song)
        {
            if (song != null)
            {
                await _context.Songs.AddAsync(song);
                await _context.SaveChangesAsync();

                return RedirectToAction("Get", new { song.ID });
            }

            return NotFound();
        }

        // Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Song song)
        {
            if (id != song.ID)
            {
                return BadRequest(ModelState);
            }

            Song result = _context.Songs.FirstOrDefault(s => s.ID == id);

            if (result == null)
            {
                return RedirectToAction("Post", song);
            }

            result.Title = song.Title;
            result.Artist = song.Artist;
            result.Genre = song.Genre;

            _context.Update(result);
            await _context.SaveChangesAsync();

            return Ok("oKKK");

        }

        // Delete
        [HttpDelete]
        public void Delete(int id)
        {

        }


    }
}