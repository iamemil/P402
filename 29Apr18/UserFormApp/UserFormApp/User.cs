using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserFormApp
{
    class User
    {
        private string _nameSurname;
        private DateTime _birthdate;
        private string _mobileNumber;

        public User(string nameSurname, DateTime birthday, string mobileNumber)
        {
            this._nameSurname = nameSurname;
            this._birthdate = birthday;
            this._mobileNumber = mobileNumber;
        }

        public string NameSurname
        {
            get
            {
                return this._nameSurname;
            }
        }
        public DateTime Birthdate
        {
            get
            {
                return this._birthdate;
            }
        }
        public string MobileNumber
        {
            get
            {
                return this._mobileNumber;
            }
        }
    }
}
