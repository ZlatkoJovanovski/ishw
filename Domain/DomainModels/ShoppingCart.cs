using ishw.Domain.DomainModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace ishw.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {

        public string ApplicationUserId { get; set; }

        public ICollection<TicketInShoppingCart> TicketInShoppingCart { get; set; }
    }
}
