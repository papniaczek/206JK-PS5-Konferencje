using System.ComponentModel.DataAnnotations;
using Konferencje.Domain.Common;
using Konferencje.Domain.Enums;

namespace Konferencje.Domain.Entities;

public class EventRegistration : BaseEntity
{
    [Required] public int EventId { get; set; }

    [Required] public int UserId { get; set; }

    [Required] public RegistrationStatus Status { get; set; } = RegistrationStatus.Pending;

    public bool IsAttendanceConfirmed { get; set; } = false;

    [Required] [MaxLength(100)] public string QrToken { get; set; } = string.Empty;
}