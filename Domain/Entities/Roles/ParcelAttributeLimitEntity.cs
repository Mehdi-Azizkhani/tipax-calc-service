using Domain.Entities.Global;
using Domain.Interfaces;
using static Domain.Common.Enums.Constants;

namespace Domain.Entities.Roles;

public class ParcelAttributeLimitEntity: BaseEntity, IUserModifyAware
{
    public int Id { get; set; }

    public int ServiceId { get; set; }

    public string Title { get; set; } = string.Empty;

    public ParcelAttributeLimitType Type { get; set; }

    public int FromValue { get; set; }

    public int ToValue { get; set; }

    public DateTimeOffset FromDate { get; set; }

    public DateTimeOffset ToDate { get; set; }

    public bool Active { get; set; }

    public int UserId { get; set; }

    public DateTimeOffset CreationDate { get; set; }

    public DateTimeOffset? ModificationDate { get; set; }
}
