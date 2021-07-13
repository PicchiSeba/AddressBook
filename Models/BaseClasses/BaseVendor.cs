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
        
        public int ID => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public IAddress Address => throw new NotImplementedException();

        public string PhoneNumber => throw new NotImplementedException();

        public string MobilePhone => throw new NotImplementedException();

        public string Website => throw new NotImplementedException();
    }
}
