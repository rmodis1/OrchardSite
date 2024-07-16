using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrchardSite.Models;

namespace OrchardSite.Data
{
    public class ContactFormContext : DbContext
    {
        public ContactFormContext (DbContextOptions<ContactFormContext> options)
            : base(options)
        {
        }

        public DbSet<OrchardSite.Models.Contact> Contact { get; set; } = default!;
    }
}
