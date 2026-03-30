using TaskManager.Client.Models;

namespace TaskManager.Client.Services;

public interface ITicketService
{
    List<Ticket> GetAllTickets();
    void AddTicket(Ticket ticket);
    Ticket? GetTicketById(int id);

    void UpdateTicketStatus(int id, TicketStatus newStatus);
}
