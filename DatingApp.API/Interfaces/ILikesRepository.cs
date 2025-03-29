using DatingApp.API.DTOs;
using DatingApp.API.Entities;
using DatingApp.API.Helpers;

namespace DatingApp.API.Interfaces;

public interface ILikesRepository
{
    Task<UserLike?> GetUserLike(Guid sourceUserId, Guid targetUserId);
    Task<PagedList<MemberDto>> GetUserLikes(LikesParams likesParams);
    Task<IEnumerable<Guid>> GetCurrentUserLikeIds(Guid currentUserId);
    void DeleteLike(UserLike like);
    void AddLike(UserLike like);
    Task<bool> SaveChanges();
}
