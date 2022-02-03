using DataAccesss.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Contracts
{
    interface IEmployeeRepository : IGenericRepository<Employee>
    {
        //Others methods
        //IEnumerable<Employee> GetBySalary();
    }
}
