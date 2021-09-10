using AddressBook.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public interface IUser
    {
        int ID { get; }
        string Username { get; }
        bool Admin { get; }
        string Password { get; }
        List<IUser> SelectAllUsernames(DBConnection connDB);
        void InsertUser(DBConnection connDB);
        void DeleteUser(DBConnection connDB, int id);
        void UpdateUser(DBConnection connDB, IUser user);
    }
}
