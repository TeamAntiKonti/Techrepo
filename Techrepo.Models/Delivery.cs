using System.ComponentModel;

namespace Techrepo.Models
{
    public enum Delivery
    {
        [Description("By customer")]
        ByCustomer,
        [Description("By seller")]
        BySalesman
    }
}