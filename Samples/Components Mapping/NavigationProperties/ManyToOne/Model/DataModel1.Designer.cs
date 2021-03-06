﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 21.06.2012 11:42:00
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

namespace ManyToOne
{

    /// <summary>
    /// There are no comments for ManyToOne.Supplier, ManyToOne in the schema.
    /// </summary>
    public partial class Supplier {

        private int _SupplierID;

        private string _CompanyName;

        private AddressType _Address;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Supplier()
        {
            this._Address = new AddressType();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for SupplierID in the schema.
        /// </summary>
        public virtual int SupplierID
        {
            get
            {
                return this._SupplierID;
            }
            set
            {
                this._SupplierID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for CompanyName in the schema.
        /// </summary>
        public virtual string CompanyName
        {
            get
            {
                return this._CompanyName;
            }
            set
            {
                this._CompanyName = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Address in the schema.
        /// </summary>
        public virtual AddressType Address
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
    }

    /// <summary>
    /// There are no comments for ManyToOne.Order, ManyToOne in the schema.
    /// </summary>
    public partial class Order {

        private int _OrderID;

        private string _Customer;

        private AddressType _ShipAddress;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Order()
        {
            this._ShipAddress = new AddressType();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for OrderID in the schema.
        /// </summary>
        public virtual int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this._OrderID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        public virtual string Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this._Customer = value;
            }
        }

    
        /// <summary>
        /// There are no comments for ShipAddress in the schema.
        /// </summary>
        public virtual AddressType ShipAddress
        {
            get
            {
                return this._ShipAddress;
            }
            set
            {
                this._ShipAddress = value;
            }
        }
    }

    /// <summary>
    /// There are no comments for ManyToOne.Country, ManyToOne in the schema.
    /// </summary>
    public partial class Country {

        private int _CountryID;

        private string _CountryName;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Country()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for CountryID in the schema.
        /// </summary>
        public virtual int CountryID
        {
            get
            {
                return this._CountryID;
            }
            set
            {
                this._CountryID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for CountryName in the schema.
        /// </summary>
        public virtual string CountryName
        {
            get
            {
                return this._CountryName;
            }
            set
            {
                this._CountryName = value;
            }
        }
    }

}

namespace ManyToOne
{

    /// <summary>
    /// There are no comments for ManyToOne.AddressType, ManyToOne in the schema.
    /// </summary>
    public partial class AddressType {

        private string _Address;

        private string _City;

        private Country _Country;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public AddressType()
        {
            OnCreated();
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
        /// There are no comments for City in the schema.
        /// </summary>
        public virtual string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this._City = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Country in the schema.
        /// </summary>
        public virtual Country Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                this._Country = value;
            }
        }
    }

}
