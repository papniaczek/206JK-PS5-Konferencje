using System.ComponentModel.DataAnnotations;
using Konferencje.Domain.Common;

namespace Konferencje.Domain.Entities;

public class Event : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(1000)]
    public string Description { get; set; } = string.Empty;

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [Required]
    [MaxLength(200)]
    public string Location { get; set; } = string.Empty;

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Limit miejsc musi wynosić co najmniej 1.")]
    public int MaxParticipants { get; set; }
}
