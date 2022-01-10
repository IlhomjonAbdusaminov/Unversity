using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unversity.IRapositories;
using Unversity.Models;

namespace Unversity.Repasitories
{
    internal class Unknown : IUnknownRepasitory
    {
        void IUnknownRepasitory.Unknown()
        {
           Console.Clear();
            begin:
            Console.Write("\n\t1)Search\t\t2)Delete\t\t3)All Teachers\t\t4)All Students\t\t0)Exit\n>>> ");
            string select = Console.ReadLine();

            if (select == "1")
            {
                Console.Clear();
                retry:
                Console.WriteLine("\tSearch");

                Console.Write("Enter Status(1/Teacher 2/Student) : ");
                string status = Console.ReadLine();

                if (status == "1")
                {
                    Console.Write("Eanter FirsnName : ");
                    string fname = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Eanter LasnName : ");
                    string lname = Console.ReadLine();
                    Console.WriteLine();

                    ISearchRepasitory search = new Search();
                    string nomsz = search.Search(status, fname, lname);
                    Console.Clear();
                    Console.WriteLine(nomsz);
                    goto begin;
                }
                else if (status == "2")
                {
                    Console.Write("Eanter FirsnName : ");
                    string fname = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Eanter LasnName : ");
                    string lname = Console.ReadLine();
                    Console.WriteLine();

                    ISearchRepasitory search = new Search();
                    string nomsz = search.Search(status, fname, lname);
                    Console.Clear();
                    Console.WriteLine(nomsz);
                    goto begin;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\tStatus Error!");
                    goto retry;
                }

            }
            else if (select == "2")
            {
                Console.Clear();
                Console.WriteLine("\tHozircha bu funksiya faol emas!");
                goto begin;
            }
            else if (select == "3")
            {
                ISearchRepasitory search = new Search();
                string nomsz = search.Search(1);
                Console.WriteLine(nomsz);
                goto begin;
                
            }
            else if (select == "4")
            {
                ISearchRepasitory search = new Search();
                string nomsz = search.Search(2);
                Console.WriteLine(nomsz);
                goto begin;
            }
            else if (select == "0")
            {
                Console.WriteLine("Thank you! Bye bye!");
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\tCommond Error! ");
                goto begin;
            }
        }

        void IUnknownRepasitory.Unknown(bool test)
        {
            Functions.LoginFunction(true);
        }
    }
}
