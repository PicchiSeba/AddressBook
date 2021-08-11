using AddressBook.DB;
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
        string ToString();
        List<IProduct> SelectAllProducts(DBConnection connDB);
        void InsertProduct(DBConnection connDB, IProduct product);
        void DeleteProduct(DBConnection connDB, int id);
        void UpdateProduct(DBConnection connDB, IProduct product);
    }
}
