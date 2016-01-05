using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        private String id;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String sex;

        public String Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        private String phoneNumber;

        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        private String account;

        public String Account
        {
            get { return account; }
            set { account = value; }
        }

        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private String subject; // bo mon

        public String Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        private String faculty; // khoa

        public String Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        
    }
}
