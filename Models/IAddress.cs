using AddressBook.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    public interface IAddress
    {
        int ID { get; }
        string Street { get; }
        string Number { get; }
        string PostalCode { get; }
        string Municipality { get; }
        string Province { get; }
        string Country { get; }
        List<IAddress> SelectAllAddresses(DBConnection connDB);
        void InsertAddress(DBConnection connDB, IAddress address);
        void DeleteAddress(DBConnection connDB, int id);
        void UpdateAddress(DBConnection connDB, IAddress address);
    }
}
