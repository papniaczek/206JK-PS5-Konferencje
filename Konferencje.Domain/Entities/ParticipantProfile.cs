using System.ComponentModel.DataAnnotations;
using Konferencje.Domain.Common;

namespace Konferencje.Domain.Entities;

public class ParticipantProfile : BaseEntity
{
    [Required] public int UserId { get; set; }

    [Required] [MaxLength(100)] public string Company { get; set; } = string.Empty;

    [Required] [MaxLength(100)] public string JobTitle { get; set; } = string.Empty;

    [Required] [MaxLength(100)] public string Industry { get; set; } = string.Empty;

    [MaxLength(1000)] public string Bio { get; set; } = string.Empty;

    [MaxLength(500)] public string? PhotoUrl { get; set; }

    [MaxLength(500)] public string Topics { get; set; } = string.Empty;

    [MaxLength(500)] public string Offers { get; set; } = string.Empty;

    [MaxLength(500)] public string Seeking { get; set; } = string.Empty;

    public bool IsVisible { get; set; } = true;

    public bool AcceptsMeetings { get; set; } = true;
}