using System;
using Techrepo.Models;

namespace Techrepo.MVP.CreateAdvert
{
    public class CreateAdvertEventArgs : EventArgs
    {
        public CreateAdvertEventArgs(Advert advert)
        {
            this.Advert = advert;
        }
        public Advert Advert { get; set; }
    }
}
