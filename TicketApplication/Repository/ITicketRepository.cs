using TicketApplication.Models;

namespace TicketApplication.Repository
{
    public interface ITicketRepository
    {
        List<Ticket> GetAll();
        Ticket? GetById(int id);
        void Add(Ticket ticket);
        void Update(Ticket ticket);
        void Delete(int id);
        List<TicketStatus> GetStatuses();
    }
}
