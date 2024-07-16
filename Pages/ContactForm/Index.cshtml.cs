using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set;}

        public async Task OnGetAsync()
        {
            var contacts = from contact in _context.Contact
                           select contact;
            
            if (!string.IsNullOrEmpty(SearchString))
            {
                contacts = contacts.Where(contact => contact.FirstName.Contains(SearchString) || 
                                                     contact.LastName.Contains(SearchString) || 
                                                     contact.Message.Contains(SearchString));
            }

            Contact = await contacts.ToListAsync();
        }
    }
}
