using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Student
    {

        string firstname;
        string lastname;
        int age;
        string address;
        int studentid;
        double phone;
        static int count = 0;
        Student()
        {
            count++;
        }
        public string full()
        {
            string name;
            name = this.firstname + " " + this.lastname;
            Console.WriteLine(name);
            return name;
        }
        public static void total()
        {
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.firstname = "teja";
            s.age = 20;
            s.lastname = "jeevan";
            s.studentid = 1465766;
            s.phone = 8134286429;
            s.full();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Console.WriteLine(s.firstname + " " + s.age + " "+s.lastname+" "+s.studentid+" "+s.phone);
            total();
            Console.ReadLine();
        }
    }
}
