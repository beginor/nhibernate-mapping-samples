//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 22.06.2012 14:17:35
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

namespace List
{
    public class MessageMap : ClassMap<Message>
    {
        public MessageMap()
        {
              Table("Message");
              LazyLoad();
              Id(x => x.Id)
                .Column("Id")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.Text)    
                .Column("Text")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(14);
        }
    }

    public class ConversationMap : ClassMap<Conversation>
    {
        public ConversationMap()
        {
              Table("Conversation");
              LazyLoad();
              Id(x => x.Id)
                .Column("Id")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.Description)    
                .Column("Description")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(40);
              HasMany<Message>(x => x.Messages)
                .Access.Property()
                .AsList(index => {
                                   index.Column("`Order`");
                                   index.Type<int>();
                                 })
                .Cascade.None()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Generic()
                .KeyColumns.Add("ConversationId", mapping => mapping.Name("ConversationId")
                                                                     .SqlType("INTEGER")
                                                                     .Not.Nullable());
        }
    }

}