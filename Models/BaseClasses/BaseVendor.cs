using AddressBook.DB;
using AddressBook.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models.BaseClasses
{
    public class BaseVendor : IVendor
    {
        private int id;
        private string name;
        private IAddress address;
        private string phoneNumber;
        private string mobilePhone;
        private string website;

        public BaseVendor()
        {

        }

        public BaseVendor(int id)
        {
            this.id = id;
        }
        
        public BaseVendor(
            string name,
            IAddress address,
            string phoneNumber,
            string mobilePhone,
            string website
            )
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.mobilePhone = mobilePhone;
            this.website = website;
        }
        
        public BaseVendor(
            int id,
            string name,
            IAddress address,
            string phoneNumber,
            string mobilePhone,
            string website
            ) : this(
                name,
                address,
                phoneNumber,
                mobilePhone,
                website
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

        public string Name
        {
            get
            {
                return name;
            }
        }

        public IAddress Address
        {
            get
            {
                return address;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
        }

        public string MobilePhone
        {
            get
            {
                return mobilePhone;
            }
        }

        public string Website
        {
            get
            {
                return website;
            }
        }

        public void SubstituteAddress(IAddress toSubstitute)
        {
            this.address = toSubstitute;
        }

        public override string ToString()
        {
            return "[" + id + "] " + name;
        }

        /// <summary>
        /// Selects all entries in 'vendors' table
        /// </summary>
        /// <returns>List of 'BaseVendor' objects</returns>
        public List<IVendor> SelectAllVendors(DBConnection connDB)
        {
            List<IVendor> allVendors = new List<IVendor>();
            List<IAddress> allAddresses = new BaseAddress().SelectAllAddresses(connDB);
            string query = "SELECT * FROM vendors";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
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
                connDB.CloseConnection();
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
        public void InsertVendor(DBConnection connDB, IVendor vendor)
        {
            string query = "INSERT INTO vendors (name, id_address, phone_number, mobile_phone, website)" +
                " VALUES('" +
                vendor.Name + "', " +
                vendor.Address.ID + ", '" +
                vendor.PhoneNumber + "', '" +
                vendor.MobilePhone + "', '" +
                vendor.Website + "');";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Deletes the entry in 'vendors' table where ID is the one given in input
        /// </summary>
        /// <param name="id">id_vendor in the database</param>
        public void DeleteVendor(DBConnection connDB, int id)
        {
            string query = "DELETE FROM vendors WHERE id_vendor=" + id.ToString() + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Updates a given entry in the 'vendors' table
        /// </summary>
        /// <param name="vendor">BaseVendor object from which the data to update will be fetched</param>
        public void UpdateVendor(DBConnection connDB, IVendor vendor)
        {
            string query = "UPDATE vendors " +
                "SET name='" + vendor.Name +
                "', id_address=" + vendor.Address.ID +
                ", phone_number='" + vendor.PhoneNumber +
                "', mobile_phone='" + vendor.MobilePhone +
                "', website='" + vendor.Website +
                "' WHERE id_vendor=" + vendor.ID + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }
    }
}
