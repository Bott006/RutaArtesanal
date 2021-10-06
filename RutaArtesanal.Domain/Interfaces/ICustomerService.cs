using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RutaArtesanal.Domain.Interfaces
{
    public interface ICustomerService{
        Task<IEnumerable<Customer>> GetAllCustomer();
        Task<Customer> GetFirst();
    }
}