using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techrepo.Data.Contracts;
using Techrepo.Models;

namespace Techrepo.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<User> repository;

        public UserService(IUnitOfWork unitOfWork, IRepository<User> repository)
        {
            // TODO: Global error messages
            if(unitOfWork == null)
            {
                throw new ArgumentNullException("UnitOfWork cannot be null");
            }
            if(repository == null)
            {
                throw new ArgumentNullException("Repository cannot be null");
            }

            this.unitOfWork = unitOfWork;
            this.repository = repository;
        }

        public User GetUserById(string id)
        {
            return this.repository.GetById(id);
        }              

        public void UpdateAvatarByUserId(string id, string path)
        {
            var user = this.GetUserById(id);
            user.AvatartPath = path;

            this.unitOfWork.Commit();            
        }
    }
}
