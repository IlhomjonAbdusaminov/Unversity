using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unversity.Models;

namespace Unversity.IRapositories
{
    internal interface ISingUpRepasitory
    {
        public void SingUp(Teacher newTeacher);
        public void SingUp(Student newStudent);
    }
}
