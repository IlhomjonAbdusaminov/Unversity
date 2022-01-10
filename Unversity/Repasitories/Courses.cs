using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unversity.IRapositories;

namespace Unversity.Repasitories
{
    internal class Courses : ICoursesRepasitory
    {
        string ICoursesRepasitory.Courses()
        {
            Console.Clear();
        ret:
            Console.WriteLine("hammaga salom");
            Console.WriteLine("\t\tCourses");
            Console.WriteLine("\n      IT                    Buisness" +
                              "\n  1)Front-end            4)ACCA" +
                              "\n  2)Bac-end(.Net)        5)Managment" +
                              "\n  3)Database             6)Marketing" 
                                );
            Console.Write("Enter your choose : ");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1": return "Front-end"; break;
                case "2": return "Bac-end(.Net)"; break;
                case "3": return "Database"; break;
                case "4": return "ACCA"; break;
                case "5": return "Managment"; break;
                case "6": return "Marketing"; break;
                default: Console.WriteLine("Error"); goto ret; 
            }


           
        }
    }
}
