using System.Collections.Generic; 
using System.Text; 
using System;
using SpringNet.Domain;
//using System.ComponentModel.DataAnnotations;
//using System.Globalization;
//using System.Web.Mvc;
//using System.Web.Security;

namespace SpringNet.Models {
    
    public class Employee {
        
        public Employee() {
			EmployeeShops = new List<EmployeeShop>();
        }
        public virtual int id { get; set; }
        public virtual IList<EmployeeShop> EmployeeShops { get; set; }
        public virtual string name { get; set; }
        public virtual string address { get; set; }
        public virtual string telephone { get; set; }
    }
}
