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
    }
}
