using Techrepo.Data.Contracts;
using Techrepo.Models;

namespace Techrepo.Services
{
    public interface IUserService
    {
        User GetUserById(string id);
        void UpdateAvatarByUserId(string id, string path);
    }
}
