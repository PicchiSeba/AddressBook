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
            database = "addressBook";
            uid = "root";
            password = "root";

            connection = new MySqlConnection(
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + password + ";"
                );
        }

        /// <summary>
        /// Pretty self-explanatory: opens a connection to the MySql Server using the credential set in the constructor
        /// </summary>
        private bool OpenConnection()
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
                }
                return false;
            }
        }

        /// <summary>
        /// Like above: but closes the connection instead
        /// </summary>
        private bool CloseConnection()
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

        /// <summary>
        /// Selects all entries from 'contacts' table
        /// </summary>
        /// <returns>List of BaseContact objects</returns>
        public List < IContact > SelectAllContacts()
        {
            List<IAddress> allAddresses = SelectAllAddresses();
            string query = "SELECT * FROM contacts";
            List<IContact> allQueries = new List<IContact>();

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    allQueries.Add(
                        new BaseContact(
                            int.Parse(dataReader["id_contact"].ToString()),
                            dataReader["name"].ToString(),
                            new BaseAddress(int.Parse(dataReader["id_address"].ToString())),
                            dataReader["phoneNumber"].ToString()
                            )
                        );
                }
                this.CloseConnection();
            }

            for(int i = 0; i < allQueries.Count; i++)
            {
                for(int j = 0; j < allAddresses.Count; j++)
                {
                    if(allQueries[i].Address.ID == allAddresses[j].ID)
                    {
                        allQueries[i].SubstituteAddress(allAddresses[j]);
                        break;
                    }
                }
            }

            return allQueries;
        }

        /// <summary>
        /// Inserts a new element in 'contacts' table
        /// </summary>
        /// <param name="name">name in the database, string, no more than 128 characters</param>
        /// <param name="addressID">id_address in the database, Integer</param>
        /// <param name="phoneNumber">phoneNumber in the database, string, max 16 characters</param>
        public void InsertContact(string name, int addressID, string phoneNumber)
        {
            string query = "INSERT INTO contacts (name, id_address, phoneNumber) " +
                "VALUES('" + name + "', '" + addressID + "', '" + phoneNumber + "')";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Remove an entry from 'contacts' table. If the address isn't used anymore removes that too
        /// </summary>
        /// <param name="id">id_contact in the database</param>
        public void DeleteContact(int id)
        {
            string query = "SELECT * FROM contacts WHERE id_contact=" + id.ToString();
            int addressID = 0;

            // finding the contact's address id
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    addressID = int.Parse(
                            dataReader["id_address"].ToString()
                    );
                }
                this.CloseConnection();
            }
            // 
            query = "DELETE FROM contacts WHERE id_contact=" + id.ToString() + ";";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }

            /*
             * This part must be rewritten considering that addresses are not used just in 'contacts' anymore
            // if there is no entry then i can delete it
            query = "SELECT * FROM contacts WHERE id_address=" + addressID + ";";
            if (this.OpenConnection())
            {
                int addressUsedBy = 0;
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                // counting
                while (dataReader.Read())
                {
                    addressUsedBy++;
                }
                this.CloseConnection();
                // deletion only if there is no address entry among all the contacts
                if (addressUsedBy == 0)
                {
                    DeleteAddress(addressID);
                }
            }
            */
        }

        /// <summary>
        /// Updates an entry in the 'contacts' table
        /// </summary>
        /// <param name="id">id_contact in the database</param>
        /// <param name="name">name in the database, string, max 16 characters</param>
        /// <param name="address">id_address in the database, int</param>
        /// <param name="phoneNumber">phoneNumber in the database, string, max 16 characters</param>
        public void UpdateContact(int id, string name, int address, string phoneNumber)
        {
            string query = "UPDATE contacts " +
                "SET name='" + name + "' " +
                ", id_address='" + address + "' " +
                ", phoneNumber='" + phoneNumber + "' " +
                "WHERE id_contact=" + id + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Search fuction in the 'Contact' window
        /// </summary>
        /// <param name="keyword">keyword to research</param>
        /// <returns>returns a List of 'BaseContact's entries that have that keyword somewhere</returns>
        public List<IContact> SearchKeywordContact(string keyword)
        {
            List<IContact> matches = new List<IContact>();

            string query = "SELECT * FROM contacts WHERE name='" + keyword + "';";
            findElemContact(query, matches);
            
            query = "SELECT * FROM contacts WHERE phoneNumber='" + keyword + "';";
            findElemContact(query, matches);

            /*query = "SELECT * FROM contacts WHERE id_address='" + keyword + "';";
            findElemContact(query, matches);*/

            return matches;
        }

        /// <summary>
        /// A List is passed and if the element sepecified in the query is found, it is added to the List
        /// </summary>
        /// <param name="query">database query, pretty self-explanatory</param>
        /// <param name="matches">List of all findings</param>
        private void findElemContact(string query, List<IContact> matches)
        {

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    bool found = false;
                    foreach (IContact singleEntry in matches)
                    {
                        if (singleEntry.ID.ToString() == dataReader["id_contact"].ToString())
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        matches.Add(
                        new BaseContact(
                            int.Parse(dataReader["id_contact"].ToString()),
                            dataReader["name"].ToString(),
                            new BaseAddress(int.Parse(dataReader["id_address"].ToString())),
                            dataReader["phoneNumber"].ToString()
                            )
                        );
                    }
                }
                this.CloseConnection();
            }

            for(int index = 0; index < matches.Count; index++)
            {
                string secondQuery = "SELECT * FROM addresses WHERE id_address=" + matches[index].Address.ID + ";";
                if (this.OpenConnection())
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        matches[index].SubstituteAddress(
                            new BaseAddress(
                                int.Parse(dataReader["id_address"].ToString()),
                                dataReader["street"].ToString(),
                                dataReader["number"].ToString(),
                                dataReader["postalCode"].ToString(),
                                dataReader["municipality"].ToString(),
                                dataReader["province"].ToString(),
                                dataReader["country"].ToString()
                                )
                            );
                    }
                    this.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Searches a single entry with the given ID in the 'contacts' table, if found returns the data as an object
        /// </summary>
        /// <param name="id">The ID to find</param>
        /// <returns>'BaseContact' object containing the contact's data, or an empty object if none was found</returns>
        public IContact GetContactByID(int id)
        {
            List < IContact > toReturn = new List<IContact>();
            toReturn.Add(new BaseContact());
            string query = "SELECT * FROM contacts WHERE id_contact=" + id + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    toReturn[0] = new BaseContact(
                        int.Parse(dataReader["ID"].ToString()),
                        dataReader["name"].ToString(),
                        new BaseAddress(int.Parse(dataReader["id_address"].ToString())),
                        dataReader["phoneNumber"].ToString()
                        );
                }
                this.CloseConnection();
            }
            return toReturn[0];
        }

        /// <summary>
        /// Selects all entries from 'addresses' table
        /// </summary>
        /// <returns>List of 'BaseAddress' objects</returns>
        public List < IAddress > SelectAllAddresses()
        {
            string query = "SELECT * FROM addresses";
            List<IAddress> allQueries = new List<IAddress>();

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    allQueries.Add(
                        new BaseAddress(
                            int.Parse(dataReader["id_address"].ToString()),
                            dataReader["street"].ToString(),
                            dataReader["number"].ToString(),
                            dataReader["postalCode"].ToString(),
                            dataReader["municipality"].ToString(),
                            dataReader["province"].ToString(),
                            dataReader["country"].ToString()
                            )
                        );
                }
                this.CloseConnection();
            }

            return allQueries;
        }

        /// <summary>
        /// Inserts a new element in 'addresses' table
        /// </summary>
        /// <param name="address">the object from which data to add is fetched</param>
        public void InsertAddress(IAddress address)
        {
            string query = "INSERT INTO addresses (street, number, postalCode, municipality, province, country) " +
                "VALUES('" + address.Street + "', '" +
                address.Number + "', '" +
                address.PostalCode + "', '" +
                address.Municipality + "', '" +
                address.Province + "', '" +
                address.Country + "')";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Remove an entry from 'addresses' table. If the address isn't used anymore removes that too
        /// </summary>
        /// <param name="id">id_address in the database</param>
        public void DeleteAddress(int id)
        {
            string query = "DELETE FROM addresses WHERE id_address=" + id.ToString() + ";";

            if (this.OpenConnection() && id != 0)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Updates an entry in the 'addresses' table
        /// </summary>
        /// <param name="address">object from which the data to update is fetched</param>
        public void UpdateAddress(IAddress address)
        {
            string query = "UPDATE addresses " +
                "SET street='" + address.Street + "' " +
                ", number='" + address.Number + "' " +
                ", postalCode='" + address.PostalCode + "' " +
                ", municipality='" + address.Municipality + "' " +
                ", province='" + address.Province + "' " +
                ", country='" + address.Country + "' " +
                "WHERE id_address=" + address.ID + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Selects all payments done by a specific user in the 'notes' table
        /// </summary>
        /// <param name="id_user">user's id to search</param>
        /// <returns>List of BaseContacts objects with all the data found</returns>
        public List < INote > SelectPaymentsByUserID(int id_user) {
            List<INote> allQueries = new List<INote>();
            string query = "SELECT * FROM notes WHERE id_user=" + id_user + ";";
            List<IContact> allContacts = SelectAllContacts();

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    IContact user = new BaseContact();
                    foreach(IContact singleContact in allContacts)
                    {
                        if (singleContact.ID == Convert.ToInt32(dataReader["id_user"].ToString()))
                        {
                            allQueries.Add(
                                new BaseNote(
                                    int.Parse(dataReader["id_note"].ToString()),
                                    singleContact,
                                    dataReader["description"].ToString(),
                                    Convert.ToSingle(dataReader["amountDebt"].ToString()),
                                    Convert.ToSingle(dataReader["amountProfit"].ToString())
                                    )
                            );
                            break;
                        }
                    }
                }
                this.CloseConnection();
            }

            return allQueries;
        }

        /// <summary>
        /// Inserts a new entry in the 'notes' table
        /// </summary>
        /// <param name="note">BaseNote object from which the data to add is fetched</param>
        public void InsertNote(INote note)
        {
            string query = "INSERT INTO notes (id_user, description, amountDebt, amountProfit) " +
                "VALUES(" +
                note.User.ID + ", '" +
                note.Description + "', " +
                note.Debt + ", " +
                note.Profit + ");";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Deletes the entry in 'notes' table that has the ID given in input
        /// </summary>
        /// <param name="id">id_note in the database</param>
        public void DeleteNote(int id)
        {
            string query = "DELETE FROM notes WHERE id_note=" + id.ToString() + ";";

            if (this.OpenConnection() && id != 0)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Updates an entry in the 'notes' table
        /// </summary>
        /// <param name="address">object from which the data to update is fetched</param>
        public void UpdateNote(INote note)
        {
            string query = "UPDATE notes " +
                "SET id_user=" + note.User.ID + 
                ", description='" + note.Description +
                "', amountDebt=" + note.Debt +
                ", amountProfit=" + note.Profit +
                " WHERE id_note=" + note.ID + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Selects all entries in 'vendors' table
        /// </summary>
        /// <returns>List of 'BaseVendor' objects</returns>
        public List<IVendor> SelectAllVendors()
        {
            List<IVendor> allVendors = new List<IVendor>();
            List<IAddress> allAddresses = SelectAllAddresses();
            string query = "SELECT * FROM vendors";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    allVendors.Add(
                        new BaseVendor(
                            int.Parse(dataReader["id_vendor"].ToString()),
                            dataReader["name"].ToString(),
                            new BaseAddress(int.Parse(dataReader["id_address"].ToString())),
                            dataReader["phone_number"].ToString(),
                            dataReader["mobile_phone"].ToString(),
                            dataReader["website"].ToString()
                            )
                        );
                }
                this.CloseConnection();
            }

            for (int i = 0; i < allVendors.Count; i++)
            {
                for (int j = 0; j < allAddresses.Count; j++)
                {
                    if (allVendors[i].Address.ID == allAddresses[j].ID)
                    {
                        allVendors[i].SubstituteAddress(allAddresses[j]);
                        break;
                    }
                }
            }
            return allVendors;
        }

        /// <summary>
        /// Inserts a new entry in 'vendors' table
        /// </summary>
        /// <param name="vendor">BaseVendor from which data to add will be fetched</param>
        public void InsertVendor(IVendor vendor)
        {
            string query = "INSERT INTO vendors (name, id_address, phone_number, mobile_phone, website)" +
                " VALUES('" +
                vendor.Name + "', " +
                vendor.Address.ID + ", '" +
                vendor.PhoneNumber + "', '" +
                vendor.MobilePhone + "', '" +
                vendor.Website + "');";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Deletes the entry in 'vendors' table where ID is the one given in input
        /// </summary>
        /// <param name="id">id_vendor in the database</param>
        public void DeleteVendor(int id)
        {
            string query = "DELETE FROM vendors WHERE id_vendor=" + id.ToString() +";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Updates a given entry in the 'vendors' table
        /// </summary>
        /// <param name="vendor">BaseVendor object from which the data to update will be fetched</param>
        public void UpdateVendor(IVendor vendor)
        {
            string query = "UPDATE vendors " +
                "SET name='" + vendor.Name +
                "', id_address=" + vendor.Address.ID +
                ", phone_number='" + vendor.PhoneNumber +
                "', mobile_phone='" + vendor.MobilePhone +
                "', website='" + vendor.Website +
                "' WHERE id_vendor=" + vendor.ID + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Selects all entries in 'products' table
        /// </summary>
        /// <returns>List of 'BaseProduct' objects</returns>
        public List<IProduct> SelectAllProducts()
        {
            List<IProduct> allProducts = new List<IProduct>();
            List<IVendor> allVendors = SelectAllVendors();
            string query = "SELECT * FROM products";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
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
                this.CloseConnection();

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
        public void AddProduct(IProduct product)
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
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Deletes the entry in 'products' table where ID is the one given in input
        /// </summary>
        /// <param name="id">id_product in the database</param>
        public void DeleteProduct(int id)
        {
            string query = "DELETE FROM products WHERE id_product=" + id.ToString() + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Updates a given entry in the 'products' table
        /// </summary>
        /// <param name="product">BaseProduct object from which the data to updated will be fetched</param>
        public void UpdateProduct(IProduct product)
        {
            string query = "UPDATE products " +
                "SET name='" + product.Name +
                "', price_untaxed=" + product.PriceUntaxed +
                ", tax_percentage=" + product.TaxPercentage +
                ", reference='" + product.Reference +
                "', barcode='" + product.Barcode +
                "', id_vendor=" + product.Vendor.ID +
                " WHERE id_product=" + product.ID + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<IBillMaster> AllMasterBills()
        {
            List<IBillMaster> toReturn = new List<IBillMaster>();
            string query = "SELECT * FROM bill_master";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    toReturn.Add(
                        new BaseBillMaster(
                            Convert.ToInt32(dataReader["id_bill_master"].ToString()),
                            dataReader["bill_number"].ToString(),
                            DateTime.Parse(dataReader["date"].ToString()),
                            new BaseVendor(Convert.ToInt32(dataReader["id_vendor"])),
                            Convert.ToSingle(dataReader["bill_base_price"].ToString()),
                            Convert.ToSingle(dataReader["bill_tax_percentage"].ToString()),
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
            }
            return toReturn;
        }

        /// <summary>
        /// Used to find all bills related to a master bill
        /// </summary>
        /// <param name="id">id_bill_master in the database</param>
        /// <returns>List of BaseBillDetail objects, representing all the simple bills realted to a master bill</returns>
        public List<IBillDetail> FindRelatedBills(int id)
        {
            List<IBillDetail> toReturn = new List<IBillDetail>();
            string query = "SELECT * FROM bill_detail WHERE id_bill_master=" + id + ";";
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
                            int.Parse(dataReader["units"].ToString())
                            )
                        );
                }
                this.CloseConnection();
            }

            List<IProduct> allProducts = SelectAllProducts();
            for (int index = 0; index <  toReturn.Count; index++)
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
    }
}
