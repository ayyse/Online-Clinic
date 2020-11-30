using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Online_Clinic.DataAccess;

namespace Online_Clinic.Views.Home
{
    public class IndexModel : PageModel
    {
        private readonly Online_Clinic.DataAccess.AppDbContext _context;

        public IndexModel(Online_Clinic.DataAccess.AppDbContext context)
        {
            _context = context;
        }

        public IList<Doktor> Doktor { get;set; }

        public async Task OnGetAsync()
        {
            Doktor = await _context.Doktorlar.ToListAsync();
        }
    }
}
