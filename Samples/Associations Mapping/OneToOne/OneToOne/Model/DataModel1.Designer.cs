﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 18.06.2012 14:36:08
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

namespace OneToOne
{

    /// <summary>
    /// There are no comments for OneToOne.Person, OneToOne in the schema.
    /// </summary>
    public partial class Person {

        private int _PersonID;

        private System.DateTime _BirthDay;

        private string _Address;

        private Contact _Contact;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Person()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for PersonID in the schema.
        /// </summary>
        public virtual int PersonID
        {
            get
            {
                return this._PersonID;
            }
            set
            {
                this._PersonID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for BirthDay in the schema.
        /// </summary>
        public virtual System.DateTime BirthDay
        {
            get
            {
                return this._BirthDay;
            }
            set
            {
                this._BirthDay = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Address in the schema.
        /// </summary>
        public virtual string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this._Address = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Contact in the schema.
        /// </summary>
        public virtual Contact Contact
        {
            get
            {
                return this._Contact;
            }
            set
            {
                this._Contact = value;
            }
        }
    }

    /// <summary>
    /// There are no comments for OneToOne.Contact, OneToOne in the schema.
    /// </summary>
    public partial class Contact {

        private int _ContactID;

        private string _Name;

        private string _Phone;

        private Person _Person;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Contact()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for ContactID in the schema.
        /// </summary>
        public virtual int ContactID
        {
            get
            {
                return this._ContactID;
            }
            set
            {
                this._ContactID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Name in the schema.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Phone in the schema.
        /// </summary>
        public virtual string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                this._Phone = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        public virtual Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person = value;
            }
        }
    }

}
