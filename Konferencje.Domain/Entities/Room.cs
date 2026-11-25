using System.ComponentModel.DataAnnotations;
using Konferencje.Domain.Common;

namespace Konferencje.Domain.Entities;

public class Room : BaseEntity
{
    [Required] public int EventId { get; set; }

    [Required][MaxLength(100)] public string Name { get; set; } = string.Empty;

    [Required][MaxLength(50)] public string FloorOrZone { get; set; } = string.Empty;

    [Required][Range(1, 10000)] public int MaxCapacity { get; set; }

    [Required][Range(0, 1000)] public int AvailableTables { get; set; }

    public bool IsActive { get; set; } = true;
}