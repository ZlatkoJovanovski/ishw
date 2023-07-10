using System;
using System.ComponentModel.DataAnnotations;
using ishw.Domain;
using ishw.Domain.DomainModels;
using ishw.Domain.Identity;

namespace ishw.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        [Key]
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public TicketAppUser OrderedBy { get; set; }

        public List<TicketsInOrder> TicketsInOrder { get; set; }

    }
}
