using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unversity.IRapositories;
using Unversity.Repasitories;

namespace Unversity.Models
{
    public class Functions
    {
        public static void LoginFunction(bool a)
        {
            Console.Clear();
            if (a)
            {
                Console.WriteLine("Login or Passvord Error");
            }
            retry:
            Console.WriteLine("\t\tLog in");
            Console.Write("  Status ( 1/Teacher or 2/Student ): ");
            string st = Console.ReadLine();

            if (st == "1" || st == "2")
            {
            
                Console.Write("  Login : ");
                string log = Console.ReadLine();
                Console.Write("  Password : ");
                string pss = Console.ReadLine();
                
                ILoginRepasitory _log;
                _log = new Login();
                _log.Login(st, log, pss);

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Commond Error!");
                goto retry;
            }


           


        }


        public static void SingUpFunction()
        {

            Console.WriteLine("\tSingUp\n");

            Console.Write("First Name : ");
            string fname = Console.ReadLine();

            Console.Write("Last Name : ");
            string lname = Console.ReadLine();

            Console.Write("Age : ");
            string age = Console.ReadLine();

            Console.Write("Email : ");
            string mail = Console.ReadLine();

            Console.Write("Phone : ");
            string phone = Console.ReadLine();

            Console.Write("Login : ");
            string log = Console.ReadLine();

            Console.Write("Password : ");
            string pass = Console.ReadLine();

        reatry:
            Console.Write("Status ( 1/Teacher or 2/Student ): ");
            string status =  Console.ReadLine();

            if (status == "1")
            {
                Console.Write("Enter Subject :");
                string subject = Console.ReadLine();

                Teacher newTeacher = new Teacher();

                newTeacher.Name = fname;
                newTeacher.LName = lname;
                newTeacher.Age = age;
                newTeacher.Email = mail;
                newTeacher.Phone = phone;
                newTeacher.Login = log;
                newTeacher.Password = pass;
                newTeacher.Subject = subject;
                newTeacher.Salary = 99;
             
                ISingUpRepasitory singUp = new SingUp();

                singUp.SingUp(newTeacher);



               
            }
            else if (status == "2")
            {
                IList<Student> userforStudents = new List<Student>();

                Console.Write("Enter Course Number : ");
                int course = int.Parse(Console.ReadLine());

                Console.Write("Choose Subject : ");
                ICoursesRepasitory _cours;
                _cours = new Courses();
                string stSubject = _cours.Courses();



                Student newStudent = new Student();

                newStudent.ID = new Guid();
                newStudent.Name = fname;
                newStudent.LName = lname;
                newStudent.Age = age;
                newStudent.Email = mail;
                newStudent.Phone = phone;
                newStudent.Course = course;
                newStudent.Login = log;
                newStudent.Password = pass;
                newStudent.Subject = stSubject;
                newStudent.Salary = 99;

                ISingUpRepasitory singUp = new SingUp();

                singUp.SingUp(newStudent);

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Xatolik!");
                goto reatry;
            }

        }


    }
}
