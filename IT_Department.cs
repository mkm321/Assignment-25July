using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    //IT Department class having employee of IT departments inherits employee class
    class IT_Department:Employee
    {
        private string qualification; 
        public IT_Department(string qual, int id, string name, string desn) : base(id, name, desn)
        {
            qualification = qual;
        }
        // Getter method to get Employee's Qualification!
        public string getQual()
        {
            return qualification;
        }
    }
}
