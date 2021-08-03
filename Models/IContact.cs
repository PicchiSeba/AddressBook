using AddressBook.DB;
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
        List<IContact> SelectAllContacts(DBConnection connDB);
        void InsertContact(DBConnection connDB, IContact contact);
        void DeleteContact(DBConnection connDB, int id);
        void UpdateContact(DBConnection connDB, IContact contact);
        List<IContact> SearchKeywordContact(DBConnection connDB, string keyword);
        IContact GetContactByID(DBConnection connDB, int id);
    }
}
