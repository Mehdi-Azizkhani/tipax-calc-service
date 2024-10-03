using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Global;

public class ConstantEntity
{
    [Key]
    public int Code { get; set; }

    [Required, MaxLength(256)]
    public string Type { get; set; } = string.Empty;

    [Required, MaxLength(256)]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; } = string.Empty;

}
