using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavedPostController : ControllerBase
    {
        private readonly WebForumContext _context;

        public SavedPostController(WebForumContext context)
        {
            _context = context;
        }

        // GET: api/SavedPost
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SavedPost>>> GetSavedPost()
        {
          if (_context.SavedPost == null)
          {
              return NotFound();
          }
            return await _context.SavedPost.ToListAsync();
        }

        // GET: api/SavedPost/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SavedPost>> GetSavedPost(int id)
        {
          if (_context.SavedPost == null)
          {
              return NotFound();
          }
            var savedPost = await _context.SavedPost.FindAsync(id);

            if (savedPost == null)
            {
                return NotFound();
            }

            return savedPost;
        }

        // PUT: api/SavedPost/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSavedPost(int id, SavedPost savedPost)
        {
            if (id != savedPost.Id)
            {
                return BadRequest();
            }

            _context.Entry(savedPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SavedPostExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SavedPost
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SavedPost>> PostSavedPost(SavedPost savedPost)
        {
          if (_context.SavedPost == null)
          {
              return Problem("Entity set 'WebForumContext.SavedPost'  is null.");
          }
            _context.SavedPost.Add(savedPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSavedPost", new { id = savedPost.Id }, savedPost);
        }

        // DELETE: api/SavedPost/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavedPost(int id)
        {
            if (_context.SavedPost == null)
            {
                return NotFound();
            }
            var savedPost = await _context.SavedPost.FindAsync(id);
            if (savedPost == null)
            {
                return NotFound();
            }

            _context.SavedPost.Remove(savedPost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SavedPostExists(int id)
        {
            return (_context.SavedPost?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
