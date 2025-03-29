namespace DatingApp.API.Entities;

public class UserLike
{
    public AppUser SourceUser { get; set; } = null!;
    public Guid SourceUserId { get; set; }
    public AppUser TargetUser { get; set; } = null!;
    public Guid TargetUserId { get; set; }
}
