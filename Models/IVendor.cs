using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public interface IVendor
    {
        int ID { get; }
        string Name { get; }
        IAddress Address { get; }
        string PhoneNumber { get; }
        string MobilePhone { get; }
        string Website { get; }
    }
}
