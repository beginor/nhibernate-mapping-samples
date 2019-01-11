//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 14.06.2012 18:59:17
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

namespace Map
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
              Table("Employee");
              LazyLoad();
              Id(x => x.EmployeeId)
                .Column("EmployeeId")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.Name)    
                .Column("Name")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(10);
        }
    }

    public class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
              Table("Department");
              LazyLoad();
              Id(x => x.DepartmentId)
                .Column("DepartmentId")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.Name)    
                .Column("Name")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(14);
              HasMany<Employee>(x => x.Employees)
                .Access.Property()
                .AsMap<string>("Name")
                .Cascade.None()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Generic()
                .KeyColumns.Add("DepartmentId", mapping => mapping.Name("DepartmentId")
                                                                     .SqlType("INTEGER")
                                                                     .Not.Nullable());
        }
    }

}
