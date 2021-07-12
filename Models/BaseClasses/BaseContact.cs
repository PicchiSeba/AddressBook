using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    public class BaseContact : IContact
    {
        private int id;
        private string name;
        private IAddress address;
        private string phoneNumber;

        public BaseContact()
        {
        }

        public BaseContact(int id, string name, IAddress address, string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
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

        public void SubstituteAddress(IAddress toCopyFrom)
        {
            this.address = toCopyFrom;
        }

        public override string ToString()
        {
            return "[" + id + "] " +
                name + ", " +
                address.ToString() + ", " +
                phoneNumber;
        }
    }
}
