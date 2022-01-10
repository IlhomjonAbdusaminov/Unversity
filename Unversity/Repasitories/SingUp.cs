using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using Unversity.IRapositories;
using Unversity.Models;
using Newtonsoft.Json;
using System.IO;

namespace Unversity.Repasitories
{
    internal class SingUp : ISingUpRepasitory
    {
        void ISingUpRepasitory.SingUp(Teacher newTeacher)
        {

                IList<Teacher> userForTeacher = new List<Teacher>();

                string resdjson = File.ReadAllText(Constants.Constants.TeacherJsonPath);
                userForTeacher = JsonConvert.DeserializeObject<List<Teacher>>(resdjson);

                userForTeacher.Add(newTeacher);

                string json = JsonConvert.SerializeObject(userForTeacher);
                File.WriteAllText(Constants.Constants.TeacherJsonPath, json);

            
           

        }

        void ISingUpRepasitory.SingUp(Student newStudent)
        {

            IList<Student> userForStudents = new List<Student>();

            string resdjson = File.ReadAllText(Constants.Constants.SrudentJsonPath);
            userForStudents = JsonConvert.DeserializeObject<List<Student>>(resdjson);

            userForStudents.Add(newStudent);

            string json = JsonConvert.SerializeObject(userForStudents);
            File.WriteAllText(Constants.Constants.SrudentJsonPath, json);
        }
        }
    }
