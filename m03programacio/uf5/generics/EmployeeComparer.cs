using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.LastName.CompareTo(y.LastName);
        }
    }
}
