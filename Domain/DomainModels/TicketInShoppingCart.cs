using ishw.Domain.DomainModels;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ishw.Domain.DomainModels
{
    public class TicketInShoppingCart : BaseEntity
    {
        public int TicketId { get; set; }

        public int CartId { get; set; }

        [ForeignKey("TicketId")]
        public Ticket Ticket { get; set; }

        [ForeignKey("CartId")]
        public ShoppingCart ShoppingCart { get; set; }

        public int Quantity { get; set; }
    }
}
