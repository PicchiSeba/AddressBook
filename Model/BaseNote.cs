using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    public class BaseNote : INote
    {
        private int id;
        private IContact user;
        private string description;
        private float debt;
        private float profit;

        public BaseNote() { }

        public BaseNote(int id, IContact user, string description, float debt, float profit)
        {
            this.id = id;
            this.user = user;
            this.description = description;
            this.debt = debt;
            this.profit = profit;
        }

        public int ID
        {
            get
            {
                return id;
            }
        }

        public IContact User
        {
            get
            {
                return user;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public float Debt
        {
            get
            {
                return debt;
            }
        }

        public float Profit
        {
            get
            {
                return profit;
            }
        }
    }
}
