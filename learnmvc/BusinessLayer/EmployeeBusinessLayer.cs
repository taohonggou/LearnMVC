using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnMVC.Models;
using LearnMVC.DataAccessLayer;

namespace LearnMVC.BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL SalesERPDAL = new SalesERPDAL();
            return SalesERPDAL.Employees.ToList();
        }
    }
}