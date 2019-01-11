//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 19.06.2012 16:39:19
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

namespace ComponentUniqueKeys
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
              Component(x => x.FactoryKey,
                        aFactoryKey => {
                        aFactoryKey.Access.Property();
                        aFactoryKey.Map(x => x.Name)    
                            .Column("FactoryName")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Not.Nullable()
                            .Length(15);
                        aFactoryKey.Map(x => x.Phone)    
                            .Column("FactoryPhone")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Not.Nullable()
                            .Length(20);
                        });
              HasManyToMany<Company>(x => x.Companies)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                .PropertyRef("FactoryKey")
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Generic()
                .ChildPropertyRef("CompanyKey")
                .Table("CompanyFactories")
                .FetchType.Join()
                .ChildKeyColumns.Add("CompanyName", mapping => mapping.Name("CompanyName")
                                                                     .SqlType("VARCHAR")
                                                                     .Not.Nullable()
                                                                     .Length(15))
                .ChildKeyColumns.Add("CompanyPhone", mapping => mapping.Name("CompanyPhone")
                                                                     .SqlType("VARCHAR")
                                                                     .Not.Nullable()
                                                                     .Length(20))
                .ParentKeyColumns.Add("FactoryName", mapping => mapping.Name("FactoryName")
                                                                     .SqlType("VARCHAR")
                                                                     .Not.Nullable()
                                                                     .Length(15))
                .ParentKeyColumns.Add("FactoryPhone", mapping => mapping.Name("FactoryPhone")
                                                                     .SqlType("VARCHAR")
                                                                     .Not.Nullable()
                                                                     .Length(20));
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
              Component(x => x.CompanyKey,
                        aCompanyKey => {
                        aCompanyKey.Access.Property();
                        aCompanyKey.Map(x => x.Name)    
                            .Column("CompanyName")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Not.Nullable()
                            .Length(15);
                        aCompanyKey.Map(x => x.Phone)    
                            .Column("CompanyPhone")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Not.Nullable()
                            .Length(20);
                        });
              HasManyToMany<Factory>(x => x.Factories)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                .PropertyRef("CompanyKey")
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Generic()
                .ChildPropertyRef("FactoryKey")
                .Table("CompanyFactories")
                .FetchType.Join()
                .ChildKeyColumns.Add("FactoryName", mapping => mapping.Name("FactoryName")
                                                                     .SqlType("VARCHAR")
                                                                     .Not.Nullable()
                                                                     .Length(15))
                .ChildKeyColumns.Add("FactoryPhone", mapping => mapping.Name("FactoryPhone")
                                                                     .SqlType("VARCHAR")
                                                                     .Not.Nullable()
                                                                     .Length(20))
                .ParentKeyColumns.Add("CompanyName", mapping => mapping.Name("CompanyName")
                                                                     .SqlType("VARCHAR")
                                                                     .Not.Nullable()
                                                                     .Length(15))
                .ParentKeyColumns.Add("CompanyPhone", mapping => mapping.Name("CompanyPhone")
                                                                     .SqlType("VARCHAR")
                                                                     .Not.Nullable()
                                                                     .Length(20));
        }
    }

}
