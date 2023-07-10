using ishw.Domain.DomainModels;
using System;

namespace ishw.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<TicketInShoppingCart> TicketsInShoppingCart { get; set; }
        public float TotalPrice { get; set; }
    }
}
