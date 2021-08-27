using AddressBook.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models.BaseClasses
{
    public class BaseProduct : IProduct
    {
        private int id;
        private string name;
        private float priceUntaxed;
        private float taxPercentage;
        private string reference;
        private string barcode;
        private IVendor vendor;

        public BaseProduct()
        {

        }

        public BaseProduct(int id)
        {
            this.id = id;
        }

        public BaseProduct(
            string name,
            float priceUntaxed,
            float taxPercentage,
            string reference,
            string barcode,
            IVendor vendor
            )
        {
            this.name = name;
            this.priceUntaxed = priceUntaxed;
            this.taxPercentage = taxPercentage;
            this.reference = reference;
            this.barcode = barcode;
            this.vendor = vendor;
        }

        public BaseProduct(
            int id,
            string name,
            float priceUntaxed,
            float taxPercentage,
            string reference,
            string barcode,
            IVendor vendor
            ) : this(
                name,
                priceUntaxed,
                taxPercentage,
                reference,
                barcode,
                vendor)
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

        public string Name
        {
            get
            {
                return name;
            }
        }

        public float PriceUntaxed
        {
            get
            {
                return priceUntaxed;
            }
        }

        public float TaxPercentage
        {
            get
            {
                return taxPercentage;
            }
        }
        public float PriceTaxed
        {
            get
            {
                return priceUntaxed + priceUntaxed * taxPercentage / 100;
            }
        }

        public string Reference
        {
            get
            {
                return reference;
            }
        }

        public string Barcode
        {
            get
            {
                return barcode;
            }
        }

        public IVendor Vendor
        {
            get
            {
                return vendor;
            }
        }

        public void SubstituteVendor(IVendor vendor)
        {
            this.vendor = vendor;
        }

        /// <summary>
        /// Selects all entries in 'products' table
        /// </summary>
        /// <returns>List of 'BaseProduct' objects</returns>
        public List<IProduct> SelectAllProducts(DBConnection connDB)
        {
            List<IProduct> allProducts = new List<IProduct>();
            List<IVendor> allVendors = new BaseVendor().SelectAllVendors(connDB);
            string query = "SELECT * FROM products";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    allProducts.Add(
                        new BaseProduct(
                            int.Parse(dataReader["id_product"].ToString()),
                            dataReader["name"].ToString(),
                            Convert.ToSingle(dataReader["price_untaxed"].ToString()),
                            Convert.ToSingle(dataReader["tax_percentage"].ToString()),
                            dataReader["reference"].ToString(),
                            dataReader["barcode"].ToString(),
                            new BaseVendor(int.Parse(dataReader["id_vendor"].ToString()))
                            )
                        );
                }
                connDB.CloseConnection();
                for (int i = 0; i < allProducts.Count; i++)
                {
                    for (int j = 0; j < allVendors.Count; j++)
                    {
                        if (allProducts[i].Vendor.ID == allVendors[j].ID)
                        {
                            allProducts[i].SubstituteVendor(allVendors[j]);
                            break;
                        }
                    }
                }
            }
            return allProducts;
        }

        /// <summary>
        /// Adds a new entry in 'products' table
        /// </summary>
        /// <param name="product">BaseProduct object from which the data to add will be fetched</param>
        public void InsertProduct(DBConnection connDB, IProduct product)
        {
            string query = "INSERT INTO products " +
                "(name, price_untaxed, tax_percentage, reference, barcode, id_vendor)" +
                " VALUES('" +
                product.Name + "', " +
                product.PriceTaxed + ", " +
                product.TaxPercentage + ", '" +
                product.Reference + "', '" +
                product.Barcode + "' ," +
                product.Vendor.ID +
                ")";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Deletes the entry in 'products' table where ID is the one given in input
        /// </summary>
        /// <param name="id">id_product in the database</param>
        public void DeleteProduct(DBConnection connDB, int id)
        {
            string query = "DELETE FROM products WHERE id_product=" + id.ToString() + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Updates a given entry in the 'products' table
        /// </summary>
        /// <param name="product">BaseProduct object from which the data to updated will be fetched</param>
        public void UpdateProduct(DBConnection connDB, IProduct product)
        {
            string query = "UPDATE products " +
                "SET name='" + product.Name +
                "', price_untaxed=" + product.PriceUntaxed +
                ", tax_percentage=" + product.TaxPercentage +
                ", reference='" + product.Reference +
                "', barcode='" + product.Barcode +
                "', id_vendor=" + product.Vendor.ID +
                " WHERE id_product=" + product.ID + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }
    }
}
