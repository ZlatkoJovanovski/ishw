using System;
using ishw.Domain.DomainModels;
using ishw.Domain.Identity;

namespace ishw.Repository.Interface;

public interface IUserRepository
{
    IEnumerable<TicketAppUser> GetAll();
    TicketAppUser Get(string id);
    void Insert(TicketAppUser entity);
    void Update(TicketAppUser entity);
    void Delete(TicketAppUser entity);
}