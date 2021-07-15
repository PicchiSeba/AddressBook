using AddressBook.Model;
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
    }
}
