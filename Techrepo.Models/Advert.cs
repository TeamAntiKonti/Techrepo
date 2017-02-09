using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Techrepo.Models
{
    public class Advert
    {
        private ICollection<User> subscribers;

        public Advert()
        {
            this.subscribers = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }

        //[Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int OwnerId { get; set; }
        public virtual User Owner { get; set; }

        public virtual ICollection<User> Subscribers
        {
            get
            {
                return this.subscribers;
            }
            set
            {
                this.subscribers = value;
            }
        }

        [Required]
        public string OwnerEmail { get; set; }

        [Required]
        public string OwnerPhone { get; set; }

        public int CategoryId { get; set; }
        public virtual AdvertCategory Category { get; set; }

        public ProductState ProductState { get; set; }

        public Delivery Delivery { get; set; }
    }
}