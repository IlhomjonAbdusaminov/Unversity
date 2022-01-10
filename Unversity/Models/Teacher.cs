using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unversity.Models
{
    internal class Teacher
    {

        public Teacher()
        {

        }

        public Guid ID { get; set; } =  Guid.NewGuid();
        public string Name { get; set; }
        public string LName { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Subject { get; set; }
        public decimal Salary { get; set; } = 12000;
    }
}
