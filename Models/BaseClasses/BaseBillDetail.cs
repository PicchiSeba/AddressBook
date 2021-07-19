using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models.BaseClasses
{
    public class BaseBillDetail : IBillDetail
    {
        private int id;
        private IProduct product;
        private int units;

        public BaseBillDetail(
            IProduct product,
            int units
            )
        {
            this.product = product;
            this.units = units;
        }

        public BaseBillDetail(
            int id,
            IProduct product,
            int units
            ) : this(
                product,
                units
                )
        {
            this.id = id;
        }

        public int IDBill
        {
            get
            {
                return id;
            }
        }

        public int IDProduct
        {
            get
            {
                return product.ID;
            }
        }

        public int Units
        {
            get
            {
                return units;
            }
        }

        public string Name
        {
            get
            {
                return product.Name;
            }
        }

        public float PriceBase
        {
            get
            {
                return product.PriceUntaxed;
            }
        }

        public float PriceTaxed
        {
            get
            {
                return product.PriceTaxed;
            }
        }
    }
}
