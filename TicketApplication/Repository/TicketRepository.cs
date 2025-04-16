using Microsoft.EntityFrameworkCore;
using TicketApplication.Models;
namespace TicketApplication.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private TicketContext context;

        public TicketRepository(TicketContext ctx)
        {
            context = ctx;
        }

        public List<Ticket> GetAll()
        {
            return context.Tickets.Include(t => t.Status).ToList();
        }

        public Ticket? GetById(int id)
        {
            return context.Tickets.Include(t => t.Status).FirstOrDefault(t => t.Id == id);
        }

        public void Add(Ticket ticket) 
        {
            context.Tickets.Add(ticket);
            context.SaveChanges();
        }
        public void Update(Ticket ticket)
        {
            context.Tickets.Update(ticket);
            context.SaveChanges();
        }
        public void Delete(int id) 
        {
            var ticket = context.Tickets.Find(id);
            if (ticket != null)
            {
                context.Tickets.Remove(ticket);
                context.SaveChanges();
            }
        }

        public List<TicketStatus> GetStatuses()
        {
            return context.TicketStatuses.ToList();
        }
    }
}
