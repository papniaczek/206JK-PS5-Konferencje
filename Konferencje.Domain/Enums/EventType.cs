using System.ComponentModel.DataAnnotations;

namespace Konferencje.Domain.Enums;

public enum EventType
{
    [Display(Name = "Konferencja")]
    Conference,

    [Display(Name = "Meetup")]
    Meetup,

    [Display(Name = "Spotkanie B2B")]
    B2BMeeting,

    [Display(Name = "Speed networking")]
    SpeedNetworking
}
