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
        int IDVendor { get; }
        float BasePrice { get; }
        float TaxPercentage { get; }
        float TotalPrice { get; }
        int Paid { get; }
        string PaymentForm { get; }
    }
}
