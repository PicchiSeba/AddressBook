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
        List<IUser> SelectAllUsers(DBConnection connDB);
        void InsertUser(DBConnection connDB, IUser user);
        void DeleteUser(DBConnection connDB, int id);
        void UpdateUser(DBConnection connDB, IUser user);
    }
}
