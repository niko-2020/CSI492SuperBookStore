using CRWBookStore.Models;
using System.Collections.Generic;

namespace CRWBookStore.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);


    }
}
