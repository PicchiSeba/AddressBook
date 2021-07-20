using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public interface IBillDetail
    {
        int IDBill { get; }
        IProduct Product { get; }
        int Units { get; }
        string Name { get; }
        float PriceBase { get; }
        float PriceTaxed { get; }
        void CorrelateProduct(IProduct product);
    }
}
