using System.ComponentModel.DataAnnotations;
using Konferencje.Domain.Common;

namespace Konferencje.Domain.Entities;

public class Speaker : BaseEntity
{
    public int SpeakerId { get; set; }
    
    [Required] public string Name { get; set; } = string.Empty;
   
    [Required] public string Surname { get; set; } = string.Empty;
   
    [Required][MaxLength(40)] public string JobTitle  { get; set; } = string.Empty;
   
    [Required][MaxLength(200)] public string ShortBio { get; set; } = string.Empty;
}