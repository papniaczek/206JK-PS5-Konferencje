using System.ComponentModel.DataAnnotations;

namespace Konferencje.Domain.Entities;

public enum RegistrationStatus
{
    Pending,
    Confirmed,
    Reserve,
    Canceled
}

public class EventRegistration
{
    public int Id { get; set; }

    [Required] public int EventId { get; set; }

    [Required] public int UserId { get; set; }

    [Required] public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Required] public RegistrationStatus Status { get; set; } = RegistrationStatus.Pending;

    public bool IsAttendanceConfirmed { get; set; } = false;

    [Required] [MaxLength(100)] public string QrToken { get; set; } = string.Empty;
}