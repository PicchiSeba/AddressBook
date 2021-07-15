using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public interface IProduct
    {
        int ID { get; }
        string Name { get; }
        float PriceUntaxed { get; }
        float TaxPercentage { get; }
        float PriceTaxed { get; }
        string Reference { get; }
        string Barcode { get; }
        IVendor Vendor { get; }
        void SubstituteVendor(IVendor vendor);
    }
}
