using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models.BaseClasses
{
    public class BaseProduct : IProduct
    {
        private int id;
        private string name;
        private float priceUntaxed;
        private float taxPercentage;
        private string reference;
        private string barcode;
        private IVendor vendor;

        public BaseProduct()
        {

        }

        public BaseProduct(
            string name,
            float priceUntaxed,
            float taxPercentage,
            string reference,
            string barcode,
            IVendor vendor
            )
        {
            this.name = name;
            this.priceUntaxed = priceUntaxed;
            this.taxPercentage = taxPercentage;
            this.reference = reference;
            this.barcode = barcode;
            this.vendor = vendor;
        }

        public BaseProduct(
            int id,
            string name,
            float priceUntaxed,
            float taxPercentage,
            string reference,
            string barcode,
            IVendor vendor
            ) : this(
                name,
                priceUntaxed,
                taxPercentage,
                reference,
                barcode,
                vendor)
        {
            this.id = id;
        }

        public int ID
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public float PriceUntaxed
        {
            get
            {
                return priceUntaxed;
            }
        }

        public float TaxPercentage
        {
            get
            {
                return taxPercentage;
            }
        }
        public float PriceTaxed
        {
            get
            {
                return priceUntaxed * taxPercentage;
            }
        }

        public string Reference
        {
            get
            {
                return reference;
            }
        }

        public string Barcode
        {
            get
            {
                return barcode;
            }
        }

        public IVendor Vendor
        {
            get
            {
                return vendor;
            }
        }

        public void SubstituteVendor(IVendor vendor)
        {
            this.vendor = vendor;
        }
    }
}
