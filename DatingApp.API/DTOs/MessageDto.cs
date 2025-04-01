using DatingApp.API.Entities;

namespace DatingApp.API.DTOs;

public class MessageDto
{
    public Guid Id { get; set; }
    public Guid SenderId { get; set; }
    public required string SenderUsername { get; set; }
    public required string SenderPhotoUrl { get; set; }
    public Guid RecipientId { get; set; }
    public required string RecipientUsername { get; set; }
    public required string RecipientPhotoUrl { get; set; }
    public required string Content { get; set; }
    public DateTime? DateRead { get; set; }
    public DateTime MessageSent { get; set; } 
}
