using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AddressBook.Model;
using AddressBook.Models;
using AddressBook.Models.BaseClasses;
using System.Globalization;

namespace AddressBook.DB
{
    public class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        /// <summary>
        /// Database connection creation
        /// These lines are based on my current MySql configuration
        /// I plan to make this editable in some way
        /// </summary>
        public DBConnection()
        {
            server = "localhost";
            database = "app_db_01";
            uid = "root";
            password = "root";

            connection = new MySqlConnection(
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + password + ";"
                );
        }

        public DBConnection(
            string server,
            string database,
            string uid,
            string password
            )
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.password = password;

            connection = new MySqlConnection(
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + password + ";"
                );
        }

        public MySqlConnection Connection
        {
            get
            {
                return connection;
            }
        }

        /// <summary>
        /// Pretty self-explanatory: opens a connection to the MySql Server using the credential set in the constructor
        /// </summary>
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Database error 0: Cannot connect to server.");
                        break;

                    case 1045:
                        MessageBox.Show("Database error 1045: Invalid username/password combination");
                        break;
                    default:
                        MessageBox.Show("Un-catched error: please see through debug mode");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Like above: but closes the connection instead
        /// </summary>
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool TestConnection()
        {
            if (this.OpenConnection())
            {
                this.CloseConnection();
                return true;
            }
            return false;
        }

        public List<IMasterBill> SelectAllMasterBills()
        {
            List<IMasterBill> toReturn = new List<IMasterBill>();
            string query = "SELECT * FROM master_bill";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
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
                this.CloseConnection();
                List<IVendor> allVendors = SelectAllVendors();
                for(int index = 0; index < toReturn.Count; index++)
                {
                    foreach(IVendor singleVendor in allVendors)
                    {
                        if(singleVendor.ID == toReturn[index].Vendor.ID)
                        {
                            toReturn[index].CorrelateVendors(singleVendor);
                            break;
                        }
                    }
                }
                for(int index = 0; index < toReturn.Count; index++)
                {
                    toReturn[index].ConnectSimpleBills(FindRelatedBills(toReturn[index].ID));
                }
            }
            return toReturn;
        }


        public void InsertMasterBill(IMasterBill masterBill)
        {
            string query = "INSERT INTO master_bill " +
                "(bill_number, date, id_vendor, paid, payment_method)" +
                " VALUES('" +
                masterBill.BillNumber + "', '" +
                masterBill.Date.ToString("yyyy-MM-dd") + "', " +
                masterBill.Vendor.ID + ", '" +
                Convert.ToInt32(masterBill.Paid) + "', '" +
                masterBill.PaymentMethod + "');";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void DeleteMasterBill(int id)
        {
            string query = "DELETE FROM master_bill WHERE id_master_bill=" + id + ";";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateMasterBill(IMasterBill masterBill)
        {
            string query = "UPDATE master_bill " +
                "SET bill_number='" + masterBill.BillNumber +
                "', date='" + masterBill.Date.ToString("yyyy-MM-dd") +
                "', id_vendor=" + masterBill.Vendor.ID +
                ", paid=" + Convert.ToInt32(masterBill.Paid) +
                ", payment_method='" + masterBill.PaymentMethod +
                "' WHERE id_master_bill=" + masterBill.ID + ";";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Used to find all the bills related to a master bill
        /// </summary>
        /// <param name="id">id_bill_master in the database</param>
        /// <returns>List of BaseBillDetail objects, representing all the simple bills realted to a master bill</returns>
        public List<IBillDetail> FindRelatedBills(int id)
        {
            List<IBillDetail> toReturn = new List<IBillDetail>();
            string query = "SELECT * FROM bill_detail WHERE id_master_bill=" + id + ";";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    toReturn.Add(
                        new BaseBillDetail(
                            int.Parse(dataReader["id_bill_detail"].ToString()),
                            new BaseProduct(Convert.ToInt32(dataReader["id_product"].ToString())),
                            int.Parse(dataReader["n_units"].ToString())
                            )
                        );
                }
                this.CloseConnection();
            }
            List<IProduct> allProducts = SelectAllProducts();
            for (int index = 0; index < toReturn.Count; index++)
            {
                foreach (IProduct singleProduct in allProducts)
                {
                    if (singleProduct.ID == toReturn[index].Product.ID)
                    {
                        toReturn[index].CorrelateProduct(singleProduct);
                        break;
                    }
                }
            }
            return toReturn;
        }

        public void InsertBillDetail(IBillDetail billDetail, int masterBillID)
        {
            string query = "INSERT INTO bill_detail" +
                "(id_master_bill, id_product, n_units)" +
                " VALUES(" +
                masterBillID + ", " +
                billDetail.Product.ID + ", " +
                billDetail.Units + ");";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void DeleteBillDetail(int id)
        {
            string query = "DELETE FROM bill_detail WHERE id_bill_detail=" + id + ";";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateBillDetail(IBillDetail billDetail, int masterBillID)
        {
            string query = "UPDATE bill_detail " +
                "SET id_master_bill=" + masterBillID +
                ", id_product=" + billDetail.Product.ID +
                ", n_units=" + billDetail.Units +
                " WHERE id_bill_detail=" + billDetail.IDBill + ";";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}
