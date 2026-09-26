using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using az_app_deepu2.Data;

namespace az_app_deepu2.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
