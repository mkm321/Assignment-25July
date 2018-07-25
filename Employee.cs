using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    //Employee Class having all the member fields
    class Employee
    {
        private int empId;
        private string empName;
        private string empDesignation;
        public Employee(int id,string name,string des)
        {
            empId = id;
            empName = name;
            empDesignation = des;
        }
        //Getter method to get Employee's ID
        public int getEmpId()
        {
            return empId;
        }
        //Getter method to get Employee's Name
        public string getEmpName()
        {
            return empName;
        }
        //Getter method to get Employee's Designation
        public string getEmpDesignation()
        {
            return empDesignation;
        }

    }
}
