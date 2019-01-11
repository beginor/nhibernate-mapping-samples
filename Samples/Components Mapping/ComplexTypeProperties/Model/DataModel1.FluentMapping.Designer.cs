//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 13.06.2012 13:18:41
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

namespace ComplexTypeProperties
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
              Map(x => x.CustomerID)    
                .Column("CustomerID")
                .CustomType("Int32")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("INTEGER")
                .Not.Nullable();
              Map(x => x.OrderDate)    
                .Column("OrderDate")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("DATETIME");
              Map(x => x.RequiredDate)    
                .Column("RequiredDate")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("DATETIME");
              Map(x => x.ShippedDate)    
                .Column("ShippedDate")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("DATETIME");
              Map(x => x.ShipVia)    
                .Column("ShipVia")
                .CustomType("Int32")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("INTEGER");
              Map(x => x.Freight)    
                .Column("Freight")
                .CustomType("Int32")
                .Access.Property()
                .Generated.Never()
                .Default("0")
                .CustomSqlType("INTEGER");
              Map(x => x.ShipName)    
                .Column("ShipName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(40);
              Component(x => x.ShipAddress,
                        aShipAddress => {
                        aShipAddress.Access.Property();
                        aShipAddress.Map(x => x.Address)    
                            .Column("ShipAddress")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(60);
                        aShipAddress.Map(x => x.City)    
                            .Column("ShipCity")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(15);
                        aShipAddress.Map(x => x.Region)    
                            .Column("ShipRegion")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(15);
                        aShipAddress.Map(x => x.PostalCode)    
                            .Column("ShipPostalCode")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(10);
                        aShipAddress.Map(x => x.Country)    
                            .Column("ShipCountry")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(15);
                        });
        }
    }

    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
              Table("Customers");
              LazyLoad();
              Id(x => x.CustomerID)
                .Column("CustomerID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.CompanyName)    
                .Column("CompanyName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Not.Nullable()
                .Length(40);
              Map(x => x.ContactName)    
                .Column("ContactName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(30);
              Map(x => x.ContactTitle)    
                .Column("ContactTitle")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(30);
              Map(x => x.Phone)    
                .Column("Phone")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(24);
              Map(x => x.Fax)    
                .Column("Fax")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(24);
              Component(x => x.Address,
                        aAddress => {
                        aAddress.Access.Property();
                        aAddress.Map(x => x.Address)    
                            .Column("Address")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(60);
                        aAddress.Map(x => x.City)    
                            .Column("City")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(15);
                        aAddress.Map(x => x.Region)    
                            .Column("Region")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(15);
                        aAddress.Map(x => x.PostalCode)    
                            .Column("PostalCode")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(10);
                        aAddress.Map(x => x.Country)    
                            .Column("Country")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(15);
                        });
        }
    }

}
