using TaskManager.Shared.DTOs;
using TaskManager.Shared.Models;

namespace TaskManager.Client.Services;

public interface ITicketService
{
    Task<List<Ticket>> GetAllTicketsAsync();
    Task<Ticket?> GetTicketByIdAsync(int id);
    Task<Ticket?> CreateTicketAsync(CreateTicketDto dto);
    Task UpdateTicketStatusAsync(int id, UpdateTicketStatusDto dto);
    Task DeleteTicketAsync(int id);
}