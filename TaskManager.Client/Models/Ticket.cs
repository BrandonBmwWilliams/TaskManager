using System.ComponentModel.DataAnnotations;

namespace TaskManager.Client.Models;

public class Ticket
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title can't exceed 100 characters")]
    public string Title { get; set; } = "";

    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; } = "";

    public TicketPriority Priority { get; set; } = TicketPriority.Medium;
    public TicketStatus Status { get; set; } = TicketStatus.Open;

    [Required(ErrorMessage = "Name is required")]
    public string SubmittedBy { get; set; } = "";

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
