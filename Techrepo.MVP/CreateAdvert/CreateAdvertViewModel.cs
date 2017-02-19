using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Techrepo.Models;
using System.Linq;

namespace Techrepo.MVP.CreateAdvert
{
    public class CreateAdvertViewModel
    {
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<AdvertCategory> AdvertCategories { get; set; }
        public Advert NewAdvert { get; set; }        

        // TODO: Ask Viktor
        public IEnumerable<string> GetProductStates()
        {
            List<string> states = new List<string>();        
            foreach (ProductState state in Enum.GetValues(typeof(ProductState))) {
                string a = GetDescription(state);
                states.Add(a);
            }

            return states;
        }

        public IEnumerable<string> GetDelivery()
        {
            List<string> deliveries = new List<string>();
            foreach (Delivery state in Enum.GetValues(typeof(Delivery)))
            {
                string a = GetDescription(state);
                deliveries.Add(a);
            }

            return deliveries;
        }

        public string GetDescription(Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }
    }
}
