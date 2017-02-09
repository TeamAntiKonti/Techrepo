using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Techrepo.Models
{
    public class City
    {
        private ICollection<Advert> adverts;
        public City()
        {
            this.adverts = new HashSet<Advert>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Advert> Adverts
        {
            get
            {
                return this.adverts;
            }
            set
            {
                this.adverts = value;
            }
        }
    }
}
