using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyPractices
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
        void InsertDepartment(string newDepartmentName);
    }
}
