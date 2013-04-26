using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpringNet.Contract;
using NHibernate;
using SpringNet.Models;

namespace SpringNet.Service
{
    public class EmployeeService : IEmployeeService
    {
        public ISessionFactory SessionFactory { get; set; }

        public void save(Employee employee)
        {
            SessionFactory.GetCurrentSession().Save(employee);
        }

        public void update(Employee employee)
        {
            SessionFactory.GetCurrentSession().Update(employee);
            SessionFactory.GetCurrentSession().Flush();
        }

        public void delete(Employee employee)
        {
            SessionFactory.GetCurrentSession().Delete(employee);
            SessionFactory.GetCurrentSession().Flush();
        }

        public IList<Employee> getAllEmployees()
        {
            return SessionFactory.GetCurrentSession().CreateCriteria<Employee>().List<Employee>().OrderBy(p => p.name).ToList<Employee>();
        }

        public Employee getEmployeeById(int id)
        {
            return SessionFactory.GetCurrentSession().Get<Employee>(id);
        }
    }
}