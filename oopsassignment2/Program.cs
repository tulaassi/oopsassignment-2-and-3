using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{
    class Employee
    {
        private int Empno;
        private string Empname;
        private double salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;
        public string EmpName
        {
            get
            {
                return Empname;
            }
            set
            {
                Empname = value;
            }
        }
        public int EmpNo
        {
            get { return Empno; }
            set { Empno = value; }

        }
        public void Sal()
        {
            salary = Convert.ToDouble(Console.ReadLine());
        }
        public void Calc()
        {
            if (salary <= 5000)
            {
                HRA = 10 * (salary / 100);
                TA = 5 * (salary / 100);
                DA = 15 * (salary / 100);
            }
            else if (salary < 10000)
            {
                HRA = 15 * (salary / 100);
                TA = 10 * (salary / 100);
                DA = 20 * (salary / 100);


            }
            else if (salary < 15000)
            {
                HRA = 20 * (salary / 100);
                TA = 15 * (salary / 100);
                DA = 25 * (salary / 100);

            }
            else if (salary < 20000)
            {
                HRA = 25 * (salary / 100);
                TA = 20 * (salary / 100);
                DA = 30 * (salary / 100);

            }
            else
            {
                HRA = 30 * (salary / 100);
                TA = 25 * (salary / 100);
                DA = 35 * (salary / 100);
            }
            GrossSalary = salary + HRA + TA + DA;


        }
        public void CalculateSalary()
        {
            PF = 10 * (GrossSalary / 100);
            TDS = 18 * (GrossSalary / 100);
            NetSalary = GrossSalary - (PF + TDS);
        }
        public void Display()
        {
            Console.WriteLine("employee no:" + Empno);
            Console.WriteLine("employee name:" + Empname);
            Console.WriteLine("employee salary:" + salary);
            Console.WriteLine("House rent allowances:" + HRA);
            Console.WriteLine("traveling allownces:{0}" + TA);
            Console.WriteLine("DA:{0}" + DA);
            Console.WriteLine("TDS:{0}" + TDS);
            Console.WriteLine("NetSalary:" + NetSalary);
            Console.WriteLine("Gross Salary:" + GrossSalary);
        }
        public static void Main()
        {
            Employee emp = new Employee();
            Console.WriteLine("enter employee no:");
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name:");
            emp.EmpName = Console.ReadLine();
            Console.WriteLine("enter employee salary:");
            emp.Sal();
            emp.Calc();
            emp.CalculateSalary();
            emp.Display();
            Console.ReadKey();





        }

    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assignment3.assignment3.EmployeeManagementSystem;

namespace assignment3
{
    internal class assignment3
    {
        public interface Iprintable
        {
            void print();
        }
        public class EmployeeManagementSystem : Iprintable
        {
            public int salary;
            public void print()
            {
                Console.WriteLine("enter the Fname of employee");
                string FirstName = Console.ReadLine();
                Console.WriteLine("enter the Lname of employee");
                string LastName = Console.ReadLine();
                Console.WriteLine("enter salary : ");
                salary = Convert.ToInt32(Console.ReadLine());
                if (salary <= 0 || salary > 20000)
                {
                    Console.WriteLine("enter valid salary");
                    print();
                }
                else if (salary < 5000)
                {
                    Console.WriteLine("employee name : {0}", FirstName + LastName);
                    Console.WriteLine("Net Salary : {0}", salary);
                    int PF = 8 * (salary / 100);
                    Console.WriteLine("Gross salary is : {0}", salary + PF);
                }
                else if (salary > 5000 && salary < 10000)
                {
                    Console.WriteLine("employee name : {0}", FirstName + LastName);
                    Console.WriteLine("Net Salary : {0}", salary);
                    int PF = 9 * (salary / 100);
                    Console.WriteLine("Gross salary is : {0}", salary + PF);

                }
                else if (salary > 10000 && salary < 20000)
                {
                    Console.WriteLine("employee name : {0}", FirstName + LastName);
                    Console.WriteLine("Net Salary : {0}", salary);
                    int PF = 10 * (salary / 100);
                    Console.WriteLine("Gross salary is : {0}", salary + PF);
                }
            }
            public class Manager : EmployeeManagementSystem
            {
                private double PetrolAllowance;
                private double FoodAllowance;
                private double OtherAllowance;

                public void Calculate()
                {
                    Console.WriteLine("ENTER MANAGER SALARY :");
                    salary = Convert.ToInt32(Console.ReadLine());
                    PetrolAllowance = 8 * (salary / 100);
                    FoodAllowance = 13 * (salary / 100);
                    OtherAllowance = 3 * (salary / 100);

                    Console.WriteLine("GROSS SALARY OF MANAGER = {0}", salary + FoodAllowance + PetrolAllowance + OtherAllowance);
                }
                public void CalculateSalary()
                {
                    Console.WriteLine("Net salary of mamnager = {0}", salary);
                }
            }
            public class MarketingExecutive : EmployeeManagementSystem
            {
                private int KmTravel;
                private int TourAllowance;
                private int TelephoneAllowance;

                public void Calcualate()
                {
                    Console.WriteLine("enter marketing executive salary : ");
                    salary = Convert.ToInt32(Console.Read());
                    Console.WriteLine("enter total distance trave in km :");
                    KmTravel = Convert.ToInt32(Console.Read());
                    TourAllowance = KmTravel * 5;
                    Console.WriteLine("Gross salary of marketing executive : {0}", salary + TourAllowance + TelephoneAllowance);

                }
                public void CalculateSalary()
                {
                    Console.WriteLine("Net salary of marketing Executive = {0}", +salary);
                }
            }

            public class Q1
            {
                public static void Main()
                {
                    Iprintable IP = new EmployeeManagementSystem();
                    IP.print();
                    EmployeeManagementSystem.Manager manager = new Manager();
                    manager.Calculate();
                    manager.CalculateSalary();
                    EmployeeManagementSystem.MarketingExecutive ME = new MarketingExecutive();
                    ME.Calcualate();
                    ME.CalculateSalary();
                    Console.ReadKey();

                }
            }
        }
    }

}






























