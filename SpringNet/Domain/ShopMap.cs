using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using SpringNet.Models;

namespace SpringNet.Domain {
    
    
    public class ShopMap : ClassMap<Shop> {
        
        public ShopMap() {
			Table("Shop");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.name).Column("name").Length(50);
			Map(x => x.address).Column("address").Length(200);
			Map(x => x.telephone).Column("telephone").Length(15);
			HasMany(x => x.EmployeeShops).KeyColumn("shop");
        }
    }
}
