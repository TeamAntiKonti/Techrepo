using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Techrepo.Models
{
    public class User : IdentityUser
    {
        private ICollection<Advert> myAdverts;
        private ICollection<Advert> favourites;

        public User()
        {
            this.myAdverts = new HashSet<Advert>();
            this.favourites = new HashSet<Advert>();
        }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string LastName { get; set; }

        public string AvatartPath { get; set; }

        //[Required]
        //[MinLength(2)]
        //[MaxLength(30)]
        //public override string UserName { get; set; }

        public virtual ICollection<Advert> MyAdverts
        {
            get
            {
                return this.myAdverts;
            }
            set
            {
                this.myAdverts = value;
            }
        }

        public virtual ICollection<Advert> Favourites
        {
            get
            {
                return this.favourites;
            }
            set
            {
                this.favourites = value;
            }
        }

        public ClaimsIdentity GenerateUserIdentity(UserManager<User> manager)
        {            
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }

    }
}
