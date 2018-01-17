using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    class User : Types.IUsers
    {
        internal User() { }

        internal int _id;
        internal string _first_name;
        internal string _last_name;
        internal string _emailAddress;
        internal string _username;
        internal string _password;
        internal DateTime _created_at;
        internal DateTime _last_login;
        internal string _avatar;


        // USER ID
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        // FIRST NAME
        public string first_name
        {
            get { return _first_name; }
            set { _first_name = value; }
        }

        // LAST NAME
        public string last_name
        {
            get { return _last_name; }
            set { _last_name = value; }
        }

        // EMAIL ADDRESS
        public string emailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        // USERNAME
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        // PASSWORD
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        // ACCOUNT CREATION DATE
        public DateTime created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }

        // LAST LOGIN
        public DateTime last_login
        {
            get { return _last_login; }
            set { _last_login = value; }
        }

        // AVATAR
        public string avatar
        {
            get { return _avatar; }
            set { _avatar = value; }
        }
    }
}
