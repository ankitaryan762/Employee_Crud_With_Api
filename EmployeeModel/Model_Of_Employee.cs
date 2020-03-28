
namespace EmployeeModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// this is model class
    /// </summary>
    public class Model_Of_Employee
    {
        /// <summary>
        /// this private variable
        /// </summary>
        private int id;

        /// <summary>
        /// this private variable
        /// </summary>
        private string fname;

        /// <summary>
        /// this private variable
        /// </summary>
        private string lname;

        /// <summary>
        /// this private variable
        /// </summary>
        private string city;

        /// <summary>
        /// this private variable
        /// </summary>
        private string address;

        /// <summary>
        /// this private variable
        /// </summary>
        private string email;

        /// <summary>
        /// this is variable
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
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

        /// <summary>
        /// this is variable
        /// </summary>
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

        /// <summary>
        /// this is variable
        /// </summary>
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

        /// <summary>
        /// this is variable
        /// </summary>
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

        /// <summary>
        /// this is variable
        /// </summary>
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

        /// <summary>
        /// this is variable
        /// </summary>
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
