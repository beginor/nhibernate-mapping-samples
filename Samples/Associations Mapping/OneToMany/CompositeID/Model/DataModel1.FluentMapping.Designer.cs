//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 14.06.2012 14:04:09
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

namespace CompositeID
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
              References(x => x.DepartmentPhone)
                .Class<DepartmentPhone>()
                .Access.Property()
                .Cascade.None()
                .LazyLoad()
                .Columns("DepartmentId", "DepartmentPhoneId");
        }
    }

    public class DepartmentPhoneMap : ClassMap<DepartmentPhone>
    {
        public DepartmentPhoneMap()
        {
              Table("DepartmentPhone");
              LazyLoad();
              CompositeId()
                .KeyProperty(x => x.DepartmentId, set => {
                    set.Type("Int32");
                    set.ColumnName("DepartmentId");
                    set.Access.Property(); } )
                .KeyProperty(x => x.PhoneID, set => {
                    set.Type("Int32");
                    set.ColumnName("PhoneID");
                    set.Access.Property(); } );
              Map(x => x.PhoneNumber)    
                .Column("PhoneNumber")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(20);
              Map(x => x.Name)    
                .Column("Name")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(14);
              HasMany<Employee>(x => x.Employees)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Generic()
                .KeyColumns.Add("DepartmentId", mapping => mapping.Name("DepartmentId")
                                                                     .SqlType("INTEGER")
                                                                     .Nullable())
                .KeyColumns.Add("DepartmentPhoneId", mapping => mapping.Name("DepartmentPhoneId")
                                                                     .SqlType("INTEGER")
                                                                     .Nullable());
        }
    }

}