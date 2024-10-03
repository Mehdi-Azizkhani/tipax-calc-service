using Domain.Entities.Global;
using Domain.Interfaces;
using static Domain.Common.Enums.Constants;

namespace Domain.Entities.Roles;

public class OrderChannelLimitEntity: BaseEntity, IUserModifyAware
{
    public int Id { get; set; }

    public int ServiceId { get; set; }

    public string Title { get; set; } = string.Empty;

    public OrderChannelLimitType Type { get; set; }

    public int Value { get; set; }

    public DateTimeOffset FromDate { get; set; }

    public DateTimeOffset ToDate { get; set; }

    public bool Active { get; set; }

    public int UserId { get; set; }

    public DateTimeOffset CreationDate { get; set; }

    public DateTimeOffset? ModificationDate { get; set; }
}
