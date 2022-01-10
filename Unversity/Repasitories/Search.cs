using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unversity.IRapositories;
using Unversity.Models;

namespace Unversity.Repasitories
{
    internal class Search : ISearchRepasitory
    {

        string ISearchRepasitory.Search(string stat, string fname, string lname)
        {
            if (stat == "1")
            {
                List<Teacher> user =new List<Teacher>();

                string resdjson = File.ReadAllText(Constants.Constants.TeacherJsonPath);
                user = JsonConvert.DeserializeObject<List<Teacher>>(resdjson);

                bool test = false;

                foreach (Teacher item in user)
                {
                    if(item.Name == fname && item.LName == lname)
                    {
                        return $"Id : {item.ID}\n" +
                            $"Name : {item.Name}\n" +
                            $"Age : {item.Age}\n" +
                            $"Email : {item.Email}\n" +
                            $"Phone : {item.Phone}\n" +
                            $"Subject : {item.Subject}\n" +
                            $"Salary : {item.Salary}\n";

                    }
                    else
                    {
                        test = true;
                    }
                }

                if (test || user.Count()==0)
                {
                    return "Teacher Not Found!";
                }
               

            }
            else if (stat == "2")
            {
                 List<Student> userFor = new List<Student>();

                bool test = false;

                string resdjson = File.ReadAllText(Constants.Constants.SrudentJsonPath);
                IList<Student> userFor1 = JsonConvert.DeserializeObject<List<Student>>(resdjson);

                foreach (Student item in userFor1)
                {
                    if(item.Name == fname && item.LName == lname)
                    {
                        return $"Id : {item.ID}\n" +
                            $"Name : {item.Name}\n" +
                            $"Last Name : {item.LName}" +
                            $"Age : {item.Age}\n" +
                            $"Course : {item.Course}\n" +
                            $"Email : {item.Email}\n" +
                            $"Phon : {item.Phone}\n" +
                            $"Subject : {item.Subject}\n" +
                            $"Salary : {item.Salary}\n";
                    }
                    else
                    {
                        test = true;
                    }
                }

                if (test || userFor.Count()==0)
                {
                    return "Student Not Found";
                }
               

            }

            return null;
        }

        string ISearchRepasitory.Search(int st)
        {
            if (st == 1)
            {
                List<Teacher> user = new List<Teacher>();

                string resdjson = File.ReadAllText(Constants.Constants.TeacherJsonPath);
                user = JsonConvert.DeserializeObject<List<Teacher>>(resdjson);

                    Console.Clear();
                if (user.Count() == 0)
                {
                    Console.WriteLine(" ");
                    Console.Clear();
                    Console.WriteLine("Base empty!");
                }

                foreach (Teacher item in user)
                {
                    Console.WriteLine( $"Id : {item.ID}\n" +
                            $"Name : {item.Name}\n" +
                            $"Age : {item.Age}\n" +
                            $"Email : {item.Email}\n" +
                            $"Phone : {item.Phone}\n" +
                            $"Subject : {item.Subject}\n" +
                            $"Salary : {item.Salary}\n"
                            );

                  
                }


            }
            else if(st == 2)
            {
                List<Student> userFor = new List<Student>();


                string resdjson = File.ReadAllText(Constants.Constants.SrudentJsonPath);
                IList<Student> userFor1 = JsonConvert.DeserializeObject<List<Student>>(resdjson);

                    Console.Clear();
                if (userFor1.Count() == 0)
                {
                    Console.WriteLine(" ");
                    Console.Clear();
                    Console.WriteLine("Base empty!");
                }

                foreach (Student item in userFor1)
                {
                    Console.WriteLine( $"Id : {item.ID}\n" +
                            $"Name : {item.Name}\n" +
                            $"Age : {item.Age}\n" +
                            $"Email : {item.Email}\n" +
                            $"Phone : {item.Phone}\n" +
                            $"Subject : {item.Subject}\n" +
                            $"Course : {item.Course}" +
                            $"Salary : {item.Salary}\n"
                            );

                }

            }

            return null;
        }
    }
}
