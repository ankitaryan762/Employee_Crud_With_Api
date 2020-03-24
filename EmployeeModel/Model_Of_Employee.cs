using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeModel
{
    class Model_Of_Employee
    {
        private int id;
        private string fname;
        private string lname;
        private string city;
        private string address;
        private string email;

        public int Id 
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            } 
        }

        public string Fname
        {
            get
            {
                return this.fname;
            }
            set
            {
                this.fname = value;
            }
        }

        public string Lname
        {
            get
            {
                return this.lname;
            }
            set
            {
                this.lname = value;
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        
    }
}
