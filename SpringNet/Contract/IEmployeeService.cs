using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringNet.Models;

namespace SpringNet.Contract
{
    public interface IEmployeeService
    {
        void save(Employee employee);
        void update(Employee employee);
        void delete(Employee employee);
        IList<Employee> getAllEmployees();
        Employee getEmployeeById(int id);
    }
}