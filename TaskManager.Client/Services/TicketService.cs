using TaskManager.Client.Models;

namespace TaskManager.Client.Services
{
    public class TicketService : ITicketService
    {
        private readonly List<Ticket> _tickets = new();
        private int _nextId = 1;
        public List<Ticket> GetAllTickets()
        {
            return _tickets;
        }
        public void AddTicket(Ticket ticket)
        {
            ticket.Id = _nextId;
            _nextId++;
            ticket.CreatedAt = DateTime.Now;
            ticket.Status = TicketStatus.Open;
            _tickets.Add(ticket);
        }
        public Ticket? GetTicketById(int id)
        {
            return _tickets.FirstOrDefault(t => t.Id == id);
        }
        public void UpdateTicketStatus(int id, TicketStatus newStatus)
        {
            var ticket = GetTicketById(id);
            if (ticket != null)
            {
                ticket.Status = newStatus;
            }
        }
    }
}
