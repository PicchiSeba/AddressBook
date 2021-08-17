using AddressBook.DB;
using MySql.Data.MySqlClient;
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
            string date,
            IVendor vendor,
            int paid,
            string paymentForm
            )
        {

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
                if(this.TaxPercentage == 0) return this.BasePrice;
                else return this.BasePrice + this.BasePrice * (this.TaxPercentage / 100);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connDB"></param>
        /// <returns></returns>
        public List<IMasterBill> SelectAllMasterBills(DBConnection connDB)
        {
            List<IMasterBill> toReturn = new List<IMasterBill>();
            string query = "SELECT * FROM master_bill";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    toReturn.Add(
                        new BaseMasterBill(
                            Convert.ToInt32(dataReader["id_master_bill"].ToString()),
                            dataReader["bill_number"].ToString(),
                            DateTime.Parse(dataReader["date"].ToString()),
                            new BaseVendor(Convert.ToInt32(dataReader["id_vendor"])),
                            Convert.ToInt32(dataReader["paid"].ToString()),
                            dataReader["payment_method"].ToString()
                            )
                        );
                }
                connDB.CloseConnection();
                List<IVendor> allVendors = new BaseVendor().SelectAllVendors(connDB);
                for (int index = 0; index < toReturn.Count; index++)
                {
                    foreach (IVendor singleVendor in allVendors)
                    {
                        if (singleVendor.ID == toReturn[index].Vendor.ID)
                        {
                            toReturn[index].CorrelateVendors(singleVendor);
                            break;
                        }
                    }
                }
                for (int index = 0; index < toReturn.Count; index++)
                {
                    toReturn[index].ConnectSimpleBills(new BaseBillDetail().FindRelatedBills(connDB, toReturn[index].ID));
                }
            }
            return toReturn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="masterBill"></param>
        public void InsertMasterBill(DBConnection connDB, IMasterBill masterBill)
        {
            string query = "INSERT INTO master_bill " +
                "(bill_number, date, id_vendor, paid, payment_method)" +
                " VALUES('" +
                masterBill.BillNumber + "', '" +
                masterBill.Date.ToString("yyyy-MM-dd") + "', " +
                masterBill.Vendor.ID + ", '" +
                Convert.ToInt32(masterBill.Paid) + "', '" +
                masterBill.PaymentMethod + "');";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteMasterBill(DBConnection connDB, int id)
        {
            string query = "DELETE FROM master_bill WHERE id_master_bill=" + id + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="masterBill"></param>
        public void UpdateMasterBill(DBConnection connDB, IMasterBill masterBill)
        {
            string query = "UPDATE master_bill " +
                "SET bill_number='" + masterBill.BillNumber +
                "', date='" + masterBill.Date.ToString("yyyy-MM-dd") +
                "', id_vendor=" + masterBill.Vendor.ID +
                ", paid=" + Convert.ToInt32(masterBill.Paid) +
                ", payment_method='" + masterBill.PaymentMethod +
                "' WHERE id_master_bill=" + masterBill.ID + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }
    }
}
