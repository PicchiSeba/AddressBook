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
        private bool paid;
        private string paymentForm;
        private List<IBillDetail> allBillsTogether;

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
            if (paid == 1) this.paid = true;
            else this.paid = false;
            this.paymentForm = paymentForm;
        }

        public BaseBillMaster(
            string billNumber,
            DateTime date,
            IVendor vendor,
            float basePrice,
            float taxPercentage,
            int paid,
            string paymentForm,
            List<IBillDetail> allBillsTogether
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
            this.allBillsTogether = allBillsTogether;
        }

        public BaseBillMaster(
            int id,
            string billNumber,
            DateTime date,
            IVendor vendor,
            float basePrice,
            float taxPercentage,
            int paid,
            string paymentForm,
            List<IBillDetail> allBillsTogether
            ) : this(
                billNumber,
                date,
                vendor,
                basePrice,
                taxPercentage,
                paid,
                paymentForm,
                allBillsTogether
                )
        {
            this.id = id;
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

        public IVendor Vendor
        {
            get
            {
                return vendor;
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

        public bool Paid
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

        public void CorrelateVendors(IVendor vendor)
        {
            this.vendor = vendor;
        }
    }
}
