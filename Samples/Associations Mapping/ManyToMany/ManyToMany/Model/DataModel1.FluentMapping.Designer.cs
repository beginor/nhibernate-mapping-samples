//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 18.06.2012 18:41:00
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

namespace ManyToMany
{
    public class FactoryMap : ClassMap<Factory>
    {
        public FactoryMap()
        {
              Table("Factories");
              LazyLoad();
              Id(x => x.FactoryID)
                .Column("FactoryID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.FactoryName)    
                .Column("FactoryName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Not.Nullable()
                .Length(15);
              HasManyToMany<Company>(x => x.Companies)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Generic()
                .Table("CompanyFactories")
                .FetchType.Join()
                .ChildKeyColumns.Add("CompanyID", mapping => mapping.Name("CompanyID")
                                                                     .SqlType("INTEGER")
                                                                     .Not.Nullable())
                .ParentKeyColumns.Add("FactoryID", mapping => mapping.Name("FactoryID")
                                                                     .SqlType("INTEGER")
                                                                     .Not.Nullable());
        }
    }

    public class CompanyMap : ClassMap<Company>
    {
        public CompanyMap()
        {
              Table("Companies");
              LazyLoad();
              Id(x => x.CompanyID)
                .Column("CompanyID")
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
                .Length(15);
              HasManyToMany<Factory>(x => x.Factories)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Generic()
                .Table("CompanyFactories")
                .FetchType.Join()
                .ChildKeyColumns.Add("FactoryID", mapping => mapping.Name("FactoryID")
                                                                     .SqlType("INTEGER")
                                                                     .Not.Nullable())
                .ParentKeyColumns.Add("CompanyID", mapping => mapping.Name("CompanyID")
                                                                     .SqlType("INTEGER")
                                                                     .Not.Nullable());
        }
    }

}
