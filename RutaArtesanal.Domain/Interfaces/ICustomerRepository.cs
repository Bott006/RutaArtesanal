using System.Collections;
using System.Reflection.PortableExecutable;
using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RutaArtesanal.Domain.Interfaces
{
    public interface ICustomerRepository
    {
         Task<IEnumerable<Customer>> GetAll();
         //Task<Customer> GetFirst();
    }
}