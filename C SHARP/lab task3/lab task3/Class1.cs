using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task3
{
    class Class1
    {
        class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student("Mithila", "123456", "CSE", 3.08f);
            obj1.showInfo();
            Triangle obj2 = new Triangle(20, 30, 40);
            obj2.ShowInfo();
            obj2.TestTriangle();
            Course obj3 = new Course("OOP2", "567894321", 4);
            obj3.ShowInfo1();
            Account obj4 = new Account("Mithila", "1234", 660);
            obj4.Deposit(660);
            obj4.Withdraw(660);
            
        }
    }
}
    }
public class Student
    {
        public String name, id, department;
        public float cgpa;

        public Student(string name, string id, string department, float cgpa)
        {
           this.name= name;
           this.id= id;
           this.department= department;
           this.cgpa= cgpa;
        }
        public void showInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Department:" + department);
            Console.WriteLine("cgpa:" + cgpa);
        }

    }
class Triangle
    {
        private int x, y, z;
        public Triangle(int x, int y, int z)
         {
             this.x = x;
             this.y = y;
             this.z = z;
         }
        public  void ShowInfo()
        {
             Console.WriteLine("length of 1st edge:" + x);
             Console.WriteLine("length of 2nd edge:" + y);
             Console.WriteLine("length of 3rd edge:" + z);
           
        }
        public void TestTriangle()
        {
            if(x==y&&y==z)
                Console.WriteLine("Triangle is equilateral");
            else if(x==y||y==z||z==x)
                Console.WriteLine("Triangle is isosceles");
            else
                Console.WriteLine("Triangle is scalene");

        }

    }
class Account
    {
        string accName, accId;
        int balance;
        public Account(string accName, string accId, int balance)
        {
            this.accName = accName;
            this.accId = accId;
            this.balance = balance;
            
            if(balance>0)
            {
                this.balance = balance;
                Console.WriteLine("Current Balance " + balance);
            }
                 

        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                this.balance = balance + amount;
                Console.WriteLine("Current balance after deposit: " + this.balance);

            }

        }
       
        public void Withdraw(int amount)
        {
            if(amount<balance){
		   this.balance= this.balance-amount;
               Console.WriteLine("Current balance after withdrawal: "+this.balance);
	   }
	   else{ 
		   Console.WriteLine("amount of withdrawal must be lesser than current balance");
	   }
   }
        }

class Course
    {
        string CourseName, CourseCode;
        int CourseCredit;

        public Course(string CourseName, string CourseCode, int CourseCredit)
        {
            this.CourseName = CourseName;
            this.CourseCode = CourseCode;
            this.CourseCredit = CourseCredit;
           
        }
        public void ShowInfo1()
        {
            Console.WriteLine("Course Name:" + CourseName);
            Console.WriteLine("Course Code:" + CourseCode);
            Console.WriteLine("Course Credit:" + CourseCredit);
            
        }

    }

