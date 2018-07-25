using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public delegate void printString(string s);
    class Program
    {
        static void printing(string s)
        {
            Console.WriteLine(s);
        }
        static void addEmployeeDetails()
        {
            int EmpID;
            string empName,empDes,empqual;
            Console.Write("Enter Employee ID :- ");
            EmpID = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name :- ");
            empName = Console.ReadLine();
            Console.Write("Enter Employee Designation :- ");
            empDes = Console.ReadLine();
            Console.Write("Enter Employee Qualification :- ");
            empqual = Console.ReadLine();
            try
            {
                if (string.IsNullOrEmpty(empqual))
                {
                    throw new QualificationException("Qualification Cannot be null!");

                }
                else
                {
                    if(empqual.Equals("BE") || empqual.Equals("BCA") || empqual.Equals("BSC"))
                    {
                        IT_Department itObj = new IT_Department(empqual, EmpID, empName, empDes);
                        Console.WriteLine();
                        Console.WriteLine("Employee added under IT department");
                        Console.WriteLine("Details are :- ");
                        Console.WriteLine("Employee Id :- "+itObj.getEmpId());
                        Console.WriteLine("Employee Name :- " + itObj.getEmpName());
                        Console.WriteLine("Employee Designation :- " + itObj.getEmpDesignation());
                        Console.WriteLine("Employee Qualification :- " + itObj.getQual());
                    }
                    else
                    {
                        Account_Department accountObj = new Account_Department(empqual, EmpID, empName, empDes);
                        Console.WriteLine("Employee added under accounts department");
                        Console.WriteLine("Details are :- ");
                        Console.WriteLine("Employee Id :- " + accountObj.getEmpId());
                        Console.WriteLine("Employee Name :- " + accountObj.getEmpName());
                        Console.WriteLine("Employee Designation :- " + accountObj.getEmpDesignation());
                        Console.WriteLine("Employee Qualification :- " + accountObj.getQual());
                    }
                }
            }
            catch (QualificationException message)
            {
                printString print = new printString(printing);
                print(message.Message);
                string filePath = @"B:\logs\logDetails.txt";
                if (!File.Exists(filePath))
                {
                    using (StreamWriter streamWriter = File.AppendText(filePath))
                    {
                        streamWriter.WriteLine(message.Message);
                        streamWriter.WriteLine();
                        streamWriter.WriteLine(message.StackTrace);
                    }
                }

            }
            finally
            {
                Console.WriteLine();
                Console.Write("Enter 1 to add Employee and 0 to exit :- ");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter 1 to add Employee and 0 to exit :- ");
            int choice = int.Parse(Console.ReadLine());
            while(choice == 1)
            {
                Console.WriteLine();
                addEmployeeDetails();
                Console.WriteLine();
                choice = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Thanks for using the service");
            Console.ReadKey();
        }
    }

    [Serializable]
    internal class QualificationException : Exception
    {
        public QualificationException()
        {
        }

        public QualificationException(string message) : base(message)
        {
        }
    }
}
