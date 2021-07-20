using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public interface IBillMaster
    {
        int ID { get; }
        string BillNumber { get; }
        DateTime Date { get; }
        IVendor Vendor { get; }
        float BasePrice { get; }
        float TaxPercentage { get; }
        float TotalPrice { get; }
        bool Paid { get; }
        string PaymentForm { get; }
        void CorrelateVendors(IVendor vendor);
    }
}
