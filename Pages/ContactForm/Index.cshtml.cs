using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrchardSite.Data;
using OrchardSite.Models;

namespace OrchardSite.Pages.ContactForm
{
    public class IndexModel : PageModel
    {
        private readonly OrchardSite.Data.ContactFormContext _context;

        public IndexModel(OrchardSite.Data.ContactFormContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Contact = await _context.Contact.ToListAsync();
        }
    }
}
