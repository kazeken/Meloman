using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Organizations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        // public virtual ObservableCollectionListSource<Employee> Employees { get; } = ObservableCollectionListSource<Employee>(()=> new Employee());
        public List<Employee> Employees { get; set; }
    }
}
