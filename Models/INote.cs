using AddressBook.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    public interface INote
    {
        int ID { get; }
        IContact User { get; }
        string Description { get; }
        float Debt { get; }
        float Profit { get; }
        List<INote> SelectPaymentsByUserID(DBConnection connDB, int id_user);
        void InsertNote(DBConnection connDB, INote note);
        void DeleteNote(DBConnection connDB, int id);
        void UpdateNote(DBConnection connDB, INote note);
    }
}
