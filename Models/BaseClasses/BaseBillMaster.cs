using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models.BaseClasses
{
    public class BaseBillMaster : IBillMaster
    {
        private int id;
        private string billNumber;
        private DateTime date;
        private IVendor vendor;
        private float basePrice;
        private float taxPercentage;
        private int paid;
        private string paymentForm;

        public BaseBillMaster()
        {

        }

        public BaseBillMaster(int id)
        {
            this.id = id;
        }

        public BaseBillMaster(
            string billNumber,
            DateTime date,
            IVendor vendor,
            float basePrice,
            float taxPercentage,
            int paid,
            string paymentForm
            )
        {

            this.billNumber = billNumber;
            this.date = date;
            this.vendor = vendor;
            this.basePrice = basePrice;
            this.taxPercentage = taxPercentage;
            this.paid = paid;
            this.paymentForm = paymentForm;
        }

        public BaseBillMaster(
            int id,
            string billNumber,
            DateTime date,
            IVendor vendor,
            float basePrice,
            float taxPercentage,
            int paid,
            string paymentForm
            ) : this(
                billNumber,
                date,
                vendor,
                basePrice,
                taxPercentage,
                paid,
                paymentForm
                )
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

        public string BillNumber
        {
            get
            {
                return billNumber;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        public int IDVendor
        {
            get
            {
                return vendor.ID;
            }
        }

        public float BasePrice
        {
            get
            {
                return basePrice;
            }
        }

        public float TaxPercentage
        {
            get
            {
                return taxPercentage;
            }
        }

        public float TotalPrice
        {
            get
            {
                return basePrice * taxPercentage;
            }
        }

        public int Paid
        {
            get
            {
                return paid;
            }
        }

        public string PaymentForm
        {
            get
            {
                return paymentForm;
            }
        }
    }
}
