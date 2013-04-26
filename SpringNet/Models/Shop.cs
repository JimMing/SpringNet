using System.Collections.Generic; 
using System.Text; 
using System;
using SpringNet.Domain;
using System.ComponentModel.DataAnnotations;

namespace SpringNet.Models {
    
    public class Shop {
        public Shop() {
			EmployeeShops = new List<EmployeeShop>();
        }
        public virtual int id { get; set; }
        public virtual IList<EmployeeShop> EmployeeShops { get; set; }

        [Required(ErrorMessageResourceName = "Shop_Name_Required", ErrorMessageResourceType= typeof(Resources.Messages))]
        public virtual string name { get; set; }

        [Required(ErrorMessageResourceName = "Shop_Address_Required", ErrorMessageResourceType = typeof(Resources.Messages))]
        public virtual string address { get; set; }

        [Required(ErrorMessageResourceName = "Shop_Telephone_Required", ErrorMessageResourceType = typeof(Resources.Messages))]
        public virtual string telephone { get; set; }
    }
}
