using System.ComponentModel.DataAnnotations;
using TaskManager.Shared.Models;

namespace TaskManager.Shared.DTOs;

public class CreateTicketDto
{
    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title can't exceed 100 characters")]
    public string Title { get; set; } = "";

    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; } = "";

    public TicketPriority Priority { get; set; } = TicketPriority.Medium;

    [Required(ErrorMessage = "Name is required")]
    public string SubmittedBy { get; set; } = "";
}
