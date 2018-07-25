using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    //Account Department class inherits Employee Class
    class Account_Department:Employee
    {
        private string qualification;
        //passing employee details in base (super class)
        public Account_Department(string qual, int id, string name, string desn) : base(id, name, desn)
        {
            qualification = qual;
        }
        //Getter method to get employee's qualification
        public string getQual()
        {
            return qualification;
        }
    }
}
