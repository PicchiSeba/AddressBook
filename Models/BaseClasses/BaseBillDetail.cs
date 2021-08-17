using AddressBook.DB;
using MySql.Data.MySqlClient;
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

        public BaseBillDetail()
        {

        }

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

        public IProduct Product
        {
            get
            {
                return product;
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

        public void CorrelateProduct(IProduct product)
        {
            this.product = product;
        }

        /// <summary>
        /// Used to find all the bills related to a master bill
        /// </summary>
        /// <param name="id">id_bill_master in the database</param>
        /// <returns>List of BaseBillDetail objects, representing all the simple bills realted to a master bill</returns>
        public List<IBillDetail> FindRelatedBills(DBConnection connDB, int id)
        {
            List<IBillDetail> toReturn = new List<IBillDetail>();
            string query = "SELECT * FROM bill_detail WHERE id_master_bill=" + id + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
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
                connDB.CloseConnection();
            }
            List<IProduct> allProducts = new BaseProduct().SelectAllProducts(connDB);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="billDetail"></param>
        /// <param name="masterBillID"></param>
        public void InsertBillDetail(DBConnection connDB, IBillDetail billDetail, int masterBillID)
        {
            string query = "INSERT INTO bill_detail" +
                "(id_master_bill, id_product, n_units)" +
                " VALUES(" +
                masterBillID + ", " +
                billDetail.Product.ID + ", " +
                billDetail.Units + ");";
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
        public void DeleteBillDetail(DBConnection connDB, int id)
        {
            string query = "DELETE FROM bill_detail WHERE id_bill_detail=" + id + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        public void UpdateBillDetail(DBConnection connDB, IBillDetail billDetail, int masterBillID)
        {
            string query = "UPDATE bill_detail " +
                "SET id_master_bill=" + masterBillID +
                ", id_product=" + billDetail.Product.ID +
                ", n_units=" + billDetail.Units +
                " WHERE id_bill_detail=" + billDetail.IDBill + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }
    }
}
