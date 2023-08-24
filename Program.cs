using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee("Joe", 47, "Male");
            Square squares = new Square();
            squares.Length = 10;
            squares.Width = 20;
            double area = squares.CalculateArea();
            double perm = squares.CalculatePerimeter();

            Console.WriteLine($"Area of Square: {area}");
            Console.WriteLine($"Perimeter of square: {perm}");
            Console.ReadLine();

            Console.WriteLine(" "); Console.WriteLine(" ");

            Circle circle = new Circle();
            circle.Radius = 10;
            double areaCircle = circle.CalculateArea();
            double permCircle = circle.CalculatePerimeter();
            Console.WriteLine($"Area of circle: {areaCircle}");
            Console.WriteLine($"Perimeter of circle: {permCircle}");
            Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Triangle triangle = new Triangle();
            triangle.Base = 10;
            triangle.Height = 20;
            triangle.Side = 30;
            double areaTriangle = triangle.CalculateArea();
            double permTriangle = triangle.CalculatePerimeter();
            Console.WriteLine($"Area of triangle: {areaTriangle}");
            Console.WriteLine($"Perimeter of triangle: {permTriangle}");
            Console.ReadLine();


            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Sphere sphere = new Sphere();
            sphere.Radius = 10;
            double areaSphere = sphere.CalculateArea();
            double permSphere = sphere.CalculatePerimeter();
            double volumeSphere = sphere.CalculateVolume();
            Console.WriteLine($"Area of sphere: {areaSphere}");
            Console.WriteLine($"Perimeter of sphere: {permSphere}");
            Console.WriteLine($"Volume of sphere: {volumeSphere}");
            Console.ReadLine();
            

            Console.WriteLine(" ");
            //test employeeslim class
            EmployeeSlim employeeSlim = new EmployeeSlim("Joe", DateTime.Now);
            employeeSlim.DisplayPersonSlimInfo();
            Console.ReadLine();


        }
    }

    class Company
    {
        //name, location, offering
        private string nameOfCompany;
        private string location;
        private string offering;

        public void setNameofCompany(string nameOfCompany)
        {
            this.nameOfCompany = nameOfCompany;
        }

        public void setlocation(string address)
        {
            this.location = address;
        }

        public void setCompanyOffering(string whatTheyDo)
        {
            this.offering = whatTheyDo;
        }

        public string getNameofCompany()
        {
            return this.nameOfCompany;
        }

        public string getLocation()
        {
            return this.location;
        }

        public string getCompanyOffering()
        { 
            return this.offering;
        }   
    }

    class Person
    {

        public string surname {  get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }

    class Employee : Person
    { 
        public Employee(string surname, double salary, string gender)
        {
            this.surname = surname;
            this.salary = salary;
            this.gender = gender;
        }

        private string surname;
        private double salary;
        private string gender;
    }

    class Customers : Person
    {

    }

    class EmployeeSlim : PersonSlim
    {
        public DateTime DateOfEmployment { get; set; }
        public EmployeeSlim(string name, DateTime date)
        {
            Name = name;
            DateOfEmployment = date;
        }
        public override void DisplayPersonSlimInfo()
        {
            Console.WriteLine($"Name: {Name}, Date Of Employment: {DateOfEmployment}");
        }
    }

    class PersonSlim
    {
        public string Name { get; set; }
        public virtual void DisplayPersonSlimInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }


    //interface

    public interface IShapes
    {
        double CalculateArea();
        double CalculatePerimeter();
        double CalculateVolume();
     }

    public class Square : IShapes 
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            double area = Length*Width;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perm = 2*(Width+Length);
            return perm;
        }

        public double CalculateVolume()
        {
            return 0;
        }


    }

    public class Circle : IShapes
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perm = 2 * Math.PI * Radius;
            return perm;
        }

        public double CalculateVolume()
        {
            return 0;
        }
    }   


    public class Triangle : IShapes
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Side { get; set; }

        public double CalculateArea()
        {
            double area = (Base * Height) / 2;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perm = Base + Height + Side;
            return perm;
        }

        public double CalculateVolume()
        {
            return 0;
        }
    }


    public class Sphere : IShapes
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            double area = 4 * Math.PI * Radius * Radius;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perm = 2 * Math.PI * Radius;
            return perm;
        }

        public double CalculateVolume()
        {
            double volume = (4 / 3) * Math.PI * Radius * Radius * Radius;
            return volume;
        }
    }   
}
