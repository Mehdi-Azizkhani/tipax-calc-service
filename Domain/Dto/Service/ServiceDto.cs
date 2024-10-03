using static Domain.Common.Enums.Constants;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Dto.Service;

public class ServiceDto: IDto
{
    public int Id { get; set; }

    public int? ParentServiceId { get; set; }

    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(10)]
    public string FromDate { get; set; } = string.Empty;

    [MaxLength(10)]
    public string? ToDate { get; set; }

    public SrviceType Type { get; set; }

    public string? Describe { get; set; }

    public bool Active { get; set; }

    public int UserId { get; set; }

    public DateTimeOffset CreationDate { get; set; }

    public DateTimeOffset? ModificationDate { get; set; }
}
