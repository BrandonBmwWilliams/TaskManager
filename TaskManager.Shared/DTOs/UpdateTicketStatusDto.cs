using TaskManager.Shared.Models;

namespace TaskManager.Shared.DTOs;

public class UpdateTicketStatusDto
{
    public TicketStatus Status { get; set; }
}