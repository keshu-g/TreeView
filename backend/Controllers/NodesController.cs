using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TreeView.Data;

namespace TreeView.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NodesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NodesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("list/{id}")]
        public async Task<ActionResult> ListNodes(int id)
        {
            var nodes = await _context.Nodes.ToListAsync();
            return Ok(new
            {
                success = true,
                Messages = "Nodes fetched succesfully",
                Data = nodes
            });
        }
    }
}
