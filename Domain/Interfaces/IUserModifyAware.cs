namespace Domain.Interfaces;

public interface IUserModifyAware
{
    int UserId { get; set; }

    DateTimeOffset CreationDate { get; set; }

    DateTimeOffset? ModificationDate { get; set; }
}
