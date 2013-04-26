using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using SpringNet.Models;

namespace SpringNet.Domain {
    
    
    public class EmployeeTypeMap : ClassMap<EmployeeType> {
        
        public EmployeeTypeMap() {
			Table("EmployeeType");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Assigned().Column("id");
			Map(x => x.name).Column("name").Length(50);
			Map(x => x.salary).Column("salary");
			HasMany(x => x.EmployeeShops).KeyColumn("employeeType");
        }
    }
}
