using System;
using Techrepo.Models;

namespace Techrepo.Web.Account.EventArguments
{
    public class UserDetailsEventArgs : EventArgs
    {
        public UserDetailsEventArgs(User user, string id)
        {
            this.User = user;
            this.Id = id;
        }
        public User User { get; set; }
        public string Id { get; set; }
    }
}