using ContactBook.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactBook.Data
{
    public class ContactBookContext : DbContext
    {
        public ContactBookContext(DbContextOptions<ContactBookContext> options) 
            : base(options) 
        {
        }
        public DbSet<Contact>Contacts { get; set; }
    }
}
