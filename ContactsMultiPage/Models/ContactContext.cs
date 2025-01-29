using Microsoft.EntityFrameworkCore;

namespace ContactsMultiPage.Models
{
    public class ContactContext : DbContext 
    {
        public ContactContext(DbContextOptions<ContactContext> options) 
            : base(options) 
        { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Fake Dad",
                    Phone = "525-180-0000",
                    Address = "123 Live Ave",
                    Note = "Not my real dad."
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Fake Mom",
                    Phone = "555-123-4567",
                    Address = "1234 Diggity Dr",
                    Note = "Best fake mom ever!"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "John Smith",
                    Phone = "525-555-4444",
                    Address = "1254 Espresso St",
                    Note = "Work partner/Team project lead."
                }
            );
        }
    }
}
