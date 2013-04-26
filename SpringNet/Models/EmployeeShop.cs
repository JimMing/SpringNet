using System.Collections.Generic; 
using System.Text; 
using System;
using SpringNet.Domain;

namespace SpringNet.Models {
    
    public class EmployeeShop {
        public EmployeeShop() { }
        public virtual long id { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual System.Nullable<System.DateTime> employmentDate { get; set; }
    }
}
