using AddressBook.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public interface IMasterBill
    {
        int ID { get; }
        string BillNumber { get; }
        DateTime Date { get; }
        IVendor Vendor { get; }
        float TotalPrice { get; }
        bool Paid { get; }
        string PaymentMethod { get; }
        List<IBillDetail> RelatedBills { get; }
        void CorrelateVendors(IVendor vendor);
        void ConnectSimpleBills(List<IBillDetail> toAdd);
        List<IMasterBill> SelectAllMasterBills(DBConnection connDB);
        void InsertMasterBill(DBConnection connDB, IMasterBill masterBill);
        void DeleteMasterBill(DBConnection connDB, int id);
        void UpdateMasterBill(DBConnection connDB, IMasterBill masterBill);
    }
}
