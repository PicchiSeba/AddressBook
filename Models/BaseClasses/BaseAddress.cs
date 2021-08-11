using AddressBook.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    public class BaseAddress : IAddress
    {
        private int id;
        private string street;
        private string number;
        private string postalCode;
        private string municipality;
        private string province;
        private string country;

        public BaseAddress()
        {

        }

        public BaseAddress(int id)
        {
            this.id = id;
        }

        public BaseAddress(
            string street,
            string number,
            string postalCode,
            string municipality,
            string province,
            string country
            )
        {
            this.street = street;
            this.number = number;
            this.postalCode = postalCode;
            this.municipality = municipality;
            this.province = province;
            this.country = country;
        }
        public BaseAddress(
            int id,
            string street,
            string number,
            string postalCode,
            string municipality,
            string province,
            string country
            ) : this(
                    street,
                    number,
                    postalCode,
                    municipality,
                    province,
                    country
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

        public string Street
        {
            get
            {
                return street;
            }
        }

        public string Number
        {
            get
            {
                return number;
            }
        }

        public string PostalCode
        {
            get
            {
                return postalCode;
            }
        }

        public string Municipality{
            get
            {
                return municipality;
            }
        }

        public string Province
        {
            get
            {
                return province;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
        }

        override public string ToString()
        {
            return "[" + id + "] " + 
                street + " " + number + ", " +
                postalCode + ", " +
                municipality + ", " +
                province + ", " +
                country;
        }

        /// <summary>
        /// Selects all entries from 'addresses' table
        /// </summary>
        /// <returns>List of 'BaseAddress' objects</returns>
        public List<IAddress> SelectAllAddresses(DBConnection connDB)
        {
            string query = "SELECT * FROM addresses";
            List<IAddress> allQueries = new List<IAddress>();
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    allQueries.Add(
                        new BaseAddress(
                            int.Parse(dataReader["id_address"].ToString()),
                            dataReader["street"].ToString(),
                            dataReader["number"].ToString(),
                            dataReader["postal_code"].ToString(),
                            dataReader["municipality"].ToString(),
                            dataReader["province"].ToString(),
                            dataReader["country"].ToString()
                            )
                        );
                }
                connDB.CloseConnection();
            }
            return allQueries;
        }

        /// <summary>
        /// Inserts a new element in 'addresses' table
        /// </summary>
        /// <param name="address">the object from which data to add is fetched</param>
        public void InsertAddress(DBConnection connDB, IAddress address)
        {
            string query = "INSERT INTO addresses (street, number, postal_code, municipality, province, country) " +
                "VALUES('" + address.Street + "', '" +
                address.Number + "', '" +
                address.PostalCode + "', '" +
                address.Municipality + "', '" +
                address.Province + "', '" +
                address.Country + "')";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Remove an entry from 'addresses' table. If the address isn't used anymore removes that too
        /// </summary>
        /// <param name="id">id_address in the database</param>
        public void DeleteAddress(DBConnection connDB, int id)
        {
            string query = "DELETE FROM addresses WHERE id_address=" + id.ToString() + ";";
            if (connDB.OpenConnection() && id != 0)
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Updates an entry in the 'addresses' table
        /// </summary>
        /// <param name="address">object from which the data to update is fetched</param>
        public void UpdateAddress(DBConnection connDB, IAddress address)
        {
            string query = "UPDATE addresses " +
                "SET street='" + address.Street + "' " +
                ", number='" + address.Number + "' " +
                ", postal_code='" + address.PostalCode + "' " +
                ", municipality='" + address.Municipality + "' " +
                ", province='" + address.Province + "' " +
                ", country='" + address.Country + "' " +
                "WHERE id_address=" + address.ID + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }
    }
}
