using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MBVault
{
    class DataObject
    {
        public DataObject(string firstname, string lastname, string email, int phone, string address, int cnp,
            int postalcode, string idcard_series, int idcard_number, DateTime birthday_date, string sex, string city,
            string county, string country, string password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.cnp = cnp;
            this.postalcode = postalcode;
            this.idcard_series = idcard_series;
            this.idcard_number = idcard_number;
            this.birthday_date = birthday_date;
            this.sex = sex;
            this.city = city;
            this.county = county;
            this.country = country;
            this.password = password;
        }

        public string firstname;
        public string lastname;
        public string email;
        public int phone;
        public string address;
        public int cnp;
        public int postalcode;
        public string idcard_series;
        public int idcard_number;
        public DateTime birthday_date;
        public string sex;
        public string city;
        public string county;
        public string country;
        public string password;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }

        public int PostalCode
        {
            get { return postalcode; }
            set { postalcode = value; }
        }
        public string Idcard_Series
        {
            get { return idcard_series; }
            set { idcard_series = value; }
        }

        public int Idcard_Number
        {
            get { return idcard_number; }
            set { idcard_number = value; }
        }

        public DateTime Birthday_Date
        {
            get { return birthday_date; }
            set { birthday_date = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string County
        {
            get { return county; }
            set { county = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}