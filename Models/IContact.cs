using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    public interface IContact
    {
        int ID { get; }
        string Name { get; }
        IAddress Address { get; }
        string PhoneNumber { get; }
        void SubstituteAddress(IAddress toSubstituteFrom);
    }
}
