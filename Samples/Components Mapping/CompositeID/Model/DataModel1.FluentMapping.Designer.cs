//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 13.06.2012 14:39:38
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
    public class DepartmentPhoneMap : ClassMap<DepartmentPhone>
    {
        public DepartmentPhoneMap()
        {
              Table("DepartmentPhone");
              LazyLoad();
              CompositeId<DepartmentPhoneType>(x => x.DepartmentPhoneID)
                .KeyProperty(x => x.DepartmentID, set => {
                    set.Type("Int32");
                    set.ColumnName("DeptID");
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
              Map(x => x.DeptName)    
                .Column("DeptName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(14);
              Map(x => x.Location)    
                .Column("Location")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(13);
        }
    }

}
