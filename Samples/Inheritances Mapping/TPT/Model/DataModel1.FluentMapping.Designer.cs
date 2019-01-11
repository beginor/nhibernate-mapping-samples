//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 20.06.2012 17:58:58
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

namespace TPT
{
    public class SnakeMap : SubclassMap<Snake>
    {
        public SnakeMap()
        {
              Table("Snake");
              LazyLoad();
              KeyColumn("ID");
              Map(x => x.IsVenomous)    
                .Column("IsVenomous")
                .CustomType("Boolean")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("BOOLEAN");
              Map(x => x.Length)    
                .Column("Length")
                .CustomType("Decimal")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("NUMERIC");
        }
    }

    public class HorseMap : SubclassMap<Horse>
    {
        public HorseMap()
        {
              Table("Horse");
              LazyLoad();
              KeyColumn("ID");
              Map(x => x.Breed)    
                .Column("Breed")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Not.Nullable()
                .Length(128);
              Map(x => x.MaximumSpeed)    
                .Column("MaximumSpeed")
                .CustomType("Decimal")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("NUMERIC");
        }
    }

    public class DogMap : SubclassMap<Dog>
    {
        public DogMap()
        {
              Table("Dog");
              LazyLoad();
              KeyColumn("ID");
              Map(x => x.Breed)    
                .Column("Breed")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Not.Nullable()
                .Length(128);
        }
    }

    public class CrocodileMap : SubclassMap<Crocodile>
    {
        public CrocodileMap()
        {
              Table("Crocodile");
              LazyLoad();
              KeyColumn("ID");
              Map(x => x.Length)    
                .Column("Length")
                .CustomType("Decimal")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("NUMERIC");
        }
    }

    public class AnimalMap : ClassMap<Animal>
    {
        public AnimalMap()
        {
              Table("Animal");
              LazyLoad();
              Id(x => x.ID)
                .Column("ID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.FoodClassification)    
                .Column("FoodClassification")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Not.Nullable()
                .Length(128);
        }
    }

}