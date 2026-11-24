using System.ComponentModel.DataAnnotations;
using Konferencje.Domain.Common;


namespace Konferencje.Domain.Entities;

public class AgendaSession : BaseEntity
{
    public int AgendaId { get; set; }
    
    [Required][MaxLength(100)] public string Title { get; set; } = string.Empty;
    
    [MaxLength(300)] public string ShortDescription { get; set; } = string.Empty;
    
    [Required] public DateTime StartTime { get; set; }
    
    [Required] public DateTime EndTime { get; set; }
    
    [Required][MaxLength(40)] public string TrackName { get; set; } = string.Empty;
    
    [Required] public int EventId { get; set; }
    
    [Required] public int SpeakerId  { get; set; }
    
    [Required] public int RoomId { get; set; }
}