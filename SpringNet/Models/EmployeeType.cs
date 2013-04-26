using System.Collections.Generic; 
using System.Text; 
using System;
using SpringNet.Domain;

namespace SpringNet.Models {
    
    public class EmployeeType {
        public EmployeeType() {
			EmployeeShops = new List<EmployeeShop>();
        }
        public virtual short id { get; set; }
        public virtual IList<EmployeeShop> EmployeeShops { get; set; }
        public virtual string name { get; set; }
        public virtual System.Nullable<decimal> salary { get; set; }
    }
}
