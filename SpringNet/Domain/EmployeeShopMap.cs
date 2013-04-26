using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using SpringNet.Models;

namespace SpringNet.Domain {
    
    
    public class EmployeeShopMap : ClassMap<EmployeeShop> {
        
        public EmployeeShopMap() {
			Table("EmployeeShop");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			References(x => x.Employee).Column("employee");
			References(x => x.Shop).Column("shop");
			References(x => x.EmployeeType).Column("employeeType");
			Map(x => x.employmentDate).Column("employmentDate");
        }
    }
}
