using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Account_Department:Employee
    {
        private string qualification;
        public Account_Department(string qual, int id, string name, string desn) : base(id, name, desn)
        {
            qualification = qual;
        }
        public string getQual()
        {
            return qualification;
        }
    }
}
