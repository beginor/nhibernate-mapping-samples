//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 13.06.2012 10:33:21
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

namespace SimpleClassID
{
    public class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
              Table("Department");
              LazyLoad();
              Id(x => x.DEPTNO)
                .Column("DEPTNO")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.DNAME)    
                .Column("DNAME")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(14);
              Map(x => x.LOC)    
                .Column("LOC")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(13);
        }
    }

}
