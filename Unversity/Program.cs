using System;
using Unversity.IRapositories;
using Unversity.Models;
using Unversity.Repasitories;

namespace Unversity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ret:
            #region About
            Console.WriteLine("\t\tWhat is Lorem Ipsum?\n  Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard\n" +
                "  psum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy\n" +
                "   text of the printing and typesetting industry.Lorem Ipsum has been typesetting industry's d dummy\n" +
                "  psum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy\n" +
                "  standaris simply dummy text of the printing and industry.Lorem Ipsum has been the industry's standard dummy\n" +
                "  psum is simply  text of the printing dummy typesetting industry.Lorem  psum is simplythe industry's standard dummy\n" +
                "  psum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy\n" +
                "  s simply dummy text of the printing and typesetting  Ipsum has been the industry's standard dummy\n");
            #endregion
            ret2:
            Console.Write("\n\t1)Log in\t\t2)Sing up\t\t0)Exit\n>>> ");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                Console.Clear();
                Functions.LoginFunction(false);

            }
            else if (choose == "2")
            {
                Console.Clear();
                Functions.SingUpFunction();
                Console.Clear();
                goto ret;

            }
           
            else if(choose == "0")
            {
                Console.WriteLine("\t\tThank you! Bye bye!");
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Commond Error!");
                goto ret2;
            }



        }
    }
}
