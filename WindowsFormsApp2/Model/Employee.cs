using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string IIN { get; set; }
        public int OrganizationsId { get; set; }

        public virtual Organizations Organizations { get; set; } = null!;
    }
}
