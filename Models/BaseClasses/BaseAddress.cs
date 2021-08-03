using AddressBook.DB;
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

        public List<IAddress> SelectAllAddresses(DBConnection connDB)
        {
            List<IAddress> toReturn = new List<IAddress>();



            return toReturn;
        }
    }
}
