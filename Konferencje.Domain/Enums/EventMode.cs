using System.ComponentModel.DataAnnotations;

namespace Konferencje.Domain.Enums;

public enum EventMode
{
    [Display(Name = "Stacjonarne")]
    OnSite,

    [Display(Name = "Online")]
    Online,

    [Display(Name = "Hybrydowe")]
    Hybrid
}
