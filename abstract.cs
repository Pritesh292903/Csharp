using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Csharp
{
    //    abstract
    //   highlight imprtant features
    //   abstract keyword with class and method
    //  you can not create an object of abstract class
    //  you can put abstract methods and non-abstract methods,
    //  data members constructors within abstract class
    //  it is compulsory for all sub classes to implement
    //  abstract methods of its parent class
    //  all the abstract method are by default vitual


    abstract class Emp
    {
        public string Name { get; set; }
        private int age;
        public string Dept { get; set; }
        private double Salary;

        public Emp()
        {
            Console.WriteLine("Emp Constructor Called");
        }

        public double getSalary()
        {
            return Salary;
        }

        public void setSalary(double Salary)
        {
            this.Salary = Salary;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18)
                    age = value;
                else
                    age = 0;
            }
        }

        public virtual void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Dept);
            Console.WriteLine("Salary: " + Salary);
        }

        public abstract void check();
    }
    //interface
    //what a classs must do but not how it will do
    //it declares only abstarct methods

    interface Itest
    {
        void Testing();//abstract method
    }

    interface icalc
    {
        void CalculateSalary();
    }
    class RegularEmployee : Emp,Itest
    {
        public void Testing()
        {
           
        }
        public void CacilateSalary()
        {
            GrossSalary = Basic + HRA + DA;
            NetSalary = GrossSalary - PF + PT;
        }
    
        private double Basic;
        private double HRA;
        private double DA;
        private double PF;
        private double PT;
        private double GrossSalary;
        private double NetSalary;

        public RegularEmployee()
        {
            Console.WriteLine("RegularEmployee Constructor Called");
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Basic: " + Basic);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("PF: " + PF);
            Console.WriteLine("PT: " + PT);
        }

        public override void check()
        {
            Console.WriteLine("Check method of RegularEmployee class");
        }

        public void Test()
        {
            Console.WriteLine("Test method of RegularEmployee class");
        }

        public static void Main(string[] args)
        {
            RegularEmployee e1 = new RegularEmployee();

            e1.Name = "Pritesh";
            e1.Age = 22;
            e1.Dept = "CE";
            e1.setSalary(100000);

            e1.Display();
            e1.check();
            e1.Test();

            Console.WriteLine("================");

            Emp e2 = new RegularEmployee();

            e2.Name = "Yash";
            e2.Age = 20;
            e2.Dept = "IT";
            e2.setSalary(50000);

            e2.Display();
            e2.check();

            Console.Read();
        }
    }
}