using Microsoft.EntityFrameworkCore;

namespace TicketApplication.Models
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options)
        {
        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    Name = "Create a new project",
                    Description = "Create a new project in Visual Studio",
                    SprintNumber = 1,
                    PointValue = 3,
                    TicketStatusId = 1
                },
                new Ticket
                {
                    Id = 2,
                    Name = "Add a new model",
                    Description = "Add a new model to the project",
                    SprintNumber = 1,
                    PointValue = 5,
                    TicketStatusId = 2
                },
                new Ticket
                {
                    Id = 3,
                    Name = "Create a new controller",
                    Description = "Create a new controller in the project",
                    SprintNumber = 1,
                    PointValue = 8,
                    TicketStatusId = 3
                }
            );

            modelBuilder.Entity<TicketStatus>().HasData(
                new TicketStatus
                {
                    Id = 1,
                    Name = "To Do"
                },
                new TicketStatus
                {
                    Id = 2,
                    Name = "In Progress"
                },
                new TicketStatus
                {
                    Id = 3,
                    Name = "Done"
                },
                new TicketStatus
                {
                    Id = 4,
                    Name = "QA"
                }
            );
        }
    }
}

