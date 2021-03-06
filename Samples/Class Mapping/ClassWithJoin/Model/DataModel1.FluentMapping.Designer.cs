//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 11.06.2012 13:59:42
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using FluentNHibernate.MappingModel.Collections;

namespace ClassWithJoin
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
              Table("Orders");
              LazyLoad();
              Id(x => x.OrderID)
                .Column("OrderID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.Company)    
                .Column("Company")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(50);
              Map(x => x.OrderDate)    
                .Column("OrderDate")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("DATETIME")
                .Not.Nullable();
              Map(x => x.Freight)    
                .Column("Freight")
                .CustomType("Double")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("REAL");
              Map(x => x.ShipDate)    
                .Column("ShipDate")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("DATETIME");
              Map(x => x.Discount)    
                .Column("Discount")
                .CustomType("Double")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("REAL");
              Join("OrderDetails", j => {
                        j.KeyColumn("OrderID");
                        j.Map(x => x.Product)    
                            .Column("Product")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(50);
                        j.Map(x => x.Price)    
                            .Column("Price")
                            .CustomType("Double")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("REAL");
                        j.Map(x => x.Quantity)    
                            .Column("Quantity")
                            .CustomType("Double")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("REAL");
                        });
        }
    }

}
