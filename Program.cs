using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    //Created to delegate print string
    public delegate void printString(string s);
    class Program
    {
        //function that uses delegate
        static void printing(string s)
        {
            Console.WriteLine(s);
        }
        // add Employee Details adding employee details in all the classes
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
            //try catch block to catch the empty qualification exception
            try
            {
                if (string.IsNullOrEmpty(empqual))
                {
                    throw new QualificationException("Qualification Cannot be null!");

                }
                else
                {
                    //To check which department employee is from!
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
                    //Adding message and stack trace to file system
                    using (StreamWriter streamWriter = File.AppendText(filePath))
                    {
                        streamWriter.WriteLine(message.Message);
                        streamWriter.WriteLine();
                        streamWriter.WriteLine(message.StackTrace);
                    }
                }

            }
            // finally block executing just printing statment!
            finally
            {
                Console.WriteLine();
                Console.Write("Enter 1 to add Employee and 0 to exit :- ");
            }
        }
        //main method
        static void Main(string[] args)
        {
            // Asking user's choice to add employee or not!
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
    // added custom exception class!
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
