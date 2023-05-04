using System.Collections.Generic;

namespace CRWBookStore.Models
{
    public class MockEmployeeRepository:IEmployeeRepository
    {
        private List<Employee> _employeeList;

      /*  public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mengni",Department = Dept.IT,Email="nikomnw@gmail.com"},
            };
        }
        */
        public Employee Add(Employee employee)
        {
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            throw new System.NotImplementedException();
        }

        public Employee GetEmployee(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}
