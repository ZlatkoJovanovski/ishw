using ishw.Domain.DomainModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ishw.Domain.Identity
{
    public class TicketAppUser : IdentityUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public virtual ShoppingCart UserShoppingCart { get; set; }

    }
}
