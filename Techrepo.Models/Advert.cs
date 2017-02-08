namespace Techrepo.Models
{
    public class Advert
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int MyProperty { get; set; }
        public string OwnerEmail { get; set; }
        public string OwnerPhone { get; set; }

        public virtual int CategoryId { get; set; }

    }
}