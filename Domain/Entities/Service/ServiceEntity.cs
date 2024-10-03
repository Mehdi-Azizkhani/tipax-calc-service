using Domain.Entities.Global;
using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using static Domain.Common.Enums.Constants;

namespace Domain.Entities.Service;

public class ServiceEntity : BaseEntity, IUserModifyAware, IActiveAware
{
    [Key]
    public int Id { get; set; }

    public int? ParentServiceId { get; set; }

    [Required, MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    [Required, MaxLength(10)]
    public string FromDate { get; set; } = string.Empty;

    [MaxLength(10)]
    public string? ToDate { get; set; }

    public SrviceType Type { get; set; }

    public string? Describe { get; set; }

    [Required]
    public bool Active { get; set; }

    public int UserId { get; set; }

    public DateTimeOffset CreationDate { get; set; }

    public DateTimeOffset? ModificationDate { get; set; }
}
