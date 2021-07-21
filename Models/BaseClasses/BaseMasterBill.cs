using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models.BaseClasses
{
    public class BaseMasterBill : IMasterBill
    {
        private int id;
        private string billNumber;
        private DateTime date;
        private IVendor vendor;
        private bool paid;
        private string paymentForm;
        private List<IBillDetail> allBillsTogether;

        public BaseMasterBill()
        {

        }

        public BaseMasterBill(int id)
        {
            this.id = id;
        }

        public BaseMasterBill(
            string billNumber,
            DateTime date,
            IVendor vendor,
            int paid,
            string paymentForm
            )
        {

            this.billNumber = billNumber;
            this.date = date;
            this.vendor = vendor;
            if (paid == 1) this.paid = true;
            else this.paid = false;
            this.paymentForm = paymentForm;
        }

        public BaseMasterBill(
            string billNumber,
            DateTime date,
            IVendor vendor,
            int paid,
            string paymentForm,
            List<IBillDetail> allBillsTogether
            ) : this(
                billNumber,
                date,
                vendor,
                paid,
                paymentForm
                )
        {
            this.allBillsTogether = allBillsTogether;
        }

        public BaseMasterBill(
            int id,
            string billNumber,
            DateTime date,
            IVendor vendor,
            int paid,
            string paymentForm,
            List<IBillDetail> allBillsTogether
            ) : this(
                billNumber,
                date,
                vendor,
                paid,
                paymentForm,
                allBillsTogether
                )
        {
            this.id = id;
        }

        public BaseMasterBill(
            int id,
            string billNumber,
            DateTime date,
            IVendor vendor,
            int paid,
            string paymentForm
            ) : this(
                billNumber,
                date,
                vendor,
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
                float toReturn = 0;
                foreach(IBillDetail singleBill in allBillsTogether)
                {
                    toReturn += singleBill.PriceBase;
                }
                return toReturn;
            }
        }

        public float TaxPercentage
        {
            get
            {
                int cnt = 0;
                float toReturn = 0;
                foreach (IBillDetail singleBill in allBillsTogether)
                {
                    toReturn += singleBill.Product.TaxPercentage;
                    cnt++;
                }
                return toReturn / cnt;
            }
        }

        public float TotalPrice
        {
            get
            {
                return this.BasePrice * this.TaxPercentage;
            }
        }

        public bool Paid
        {
            get
            {
                return paid;
            }
        }

        public string PaymentMethod
        {
            get
            {
                return paymentForm;
            }
        }

        public List<IBillDetail> RelatedBills
        {
            get
            {
                return allBillsTogether;
            }
        }

        public void CorrelateVendors(IVendor vendor)
        {
            this.vendor = vendor;
        }

        public void ConnectSimpleBills(List<IBillDetail> toAdd)
        {
            this.allBillsTogether = toAdd;
        }
    }
}
