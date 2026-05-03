
using CompaniOn.Core;
using Microsoft.AspNetCore.JsonPatch;

namespace CompaniOn.Infrastructure.Interfaces
{
    public interface IUsersRepository : IBaseRepository<User, int, UsersSearchObject>
    {
        Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<User?> ChangeEmailAsync(int userId, JsonPatchDocument jsonPatch, CancellationToken cancellationToken=default);
    }
}
