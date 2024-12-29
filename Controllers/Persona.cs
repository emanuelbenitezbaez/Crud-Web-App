using CrudWebApp.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudWebApp.Controllers
{
    public class Persona(PersonaDbContext context) : Controller
    {
        private readonly PersonaDbContext _context = context;
        public async Task <IActionResult> Index()
        {
            var personas = await _context.Personas.ToListAsync();
            return View(personas);
        }
    }
}
