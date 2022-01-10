using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unversity.IRapositories;
using Unversity.Models;

namespace Unversity.Repasitories
{
    internal class Login : ILoginRepasitory
    {
        void ILoginRepasitory.Login(string st, string log, string pass)
        {

            if(st == "1")
            {
                List<Teacher> teacher = new List<Teacher>();

                string resdjson = File.ReadAllText(Constants.Constants.TeacherJsonPath);

                teacher = JsonConvert.DeserializeObject<List<Teacher>>(resdjson);

                bool test = false;

                IUnknownRepasitory fs = new Unknown();


                foreach (var item in teacher)
                {
                    if (item.Login == log && item.Password == pass)
                    {
                        fs.Unknown();
                        test = false;


                    }
                    else
                    {
                        test = true;
                    }
                }
                if (test || teacher.Count() == 0)
                { 
                    fs.Unknown(test);
                }


            }
            else if(st == "2")
            {
                List<Student> student = new List<Student>();

                string resdjson = File.ReadAllText(Constants.Constants.SrudentJsonPath);

                student = JsonConvert.DeserializeObject<List<Student>>(resdjson);

                bool test = false;

                IUnknownRepasitory fs = new Unknown();

                foreach (var item in student)
                {
                    if (item.Login == log && item.Password == pass)
                    {
                        fs.Unknown();
                        test = false;

                    }
                    else
                    {
                        test = true;
                    }
                }

                if (test || student.Count() == 0)
                {
                    fs.Unknown(test);
                }
            }



        }
    }
}
