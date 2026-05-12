using System.Net.Http.Json;
using TaskManager.Shared.DTOs;
using TaskManager.Shared.Models;

namespace TaskManager.Client.Services;

public class ApiTicketService : ITicketService
{
    private readonly HttpClient _http;

    public ApiTicketService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Ticket>> GetAllTicketsAsync()
    {
        var result = await _http.GetFromJsonAsync<List<Ticket>>("api/tickets");
        return result ?? new List<Ticket>();
    }

    public async Task<Ticket?> GetTicketByIdAsync(int id)
    {
        try
        {
            return await _http.GetFromJsonAsync<Ticket>($"api/tickets/{id}");
        }
        catch (HttpRequestException)
        {
            return null;
        }
    }

    public async Task<Ticket?> CreateTicketAsync(CreateTicketDto dto)
    {
        var response = await _http.PostAsJsonAsync("api/tickets", dto);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<Ticket>();
        }
        return null;
    }

    public async Task UpdateTicketStatusAsync(int id, UpdateTicketStatusDto dto)
    {
        await _http.PutAsJsonAsync($"api/tickets/{id}/status", dto);
    }

    public async Task DeleteTicketAsync(int id)
    {
        await _http.DeleteAsync($"api/tickets/{id}");
    }
}