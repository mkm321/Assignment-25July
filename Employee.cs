using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
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
        public int getEmpId()
        {
            return empId;
        }
        public string getEmpName()
        {
            return empName;
        }
        public string getEmpDesignation()
        {
            return empDesignation;
        }

    }
}
