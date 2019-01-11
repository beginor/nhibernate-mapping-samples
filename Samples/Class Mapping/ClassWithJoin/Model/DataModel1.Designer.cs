﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 11.06.2012 13:59:42
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

namespace ClassWithJoin
{

    /// <summary>
    /// There are no comments for ClassWithJoin.Order, ClassWithJoin in the schema.
    /// </summary>
    public partial class Order {

        private int _OrderID;

        private string _Company;

        private System.DateTime _OrderDate;

        private System.Nullable<double> _Freight;

        private System.Nullable<System.DateTime> _ShipDate;

        private System.Nullable<double> _Discount;

        private string _Product;

        private System.Nullable<double> _Price;

        private System.Nullable<double> _Quantity;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Order()
        {
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
        /// There are no comments for Company in the schema.
        /// </summary>
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this._Company = value;
            }
        }

    
        /// <summary>
        /// There are no comments for OrderDate in the schema.
        /// </summary>
        public virtual System.DateTime OrderDate
        {
            get
            {
                return this._OrderDate;
            }
            set
            {
                this._OrderDate = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Freight in the schema.
        /// </summary>
        public virtual System.Nullable<double> Freight
        {
            get
            {
                return this._Freight;
            }
            set
            {
                this._Freight = value;
            }
        }

    
        /// <summary>
        /// There are no comments for ShipDate in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> ShipDate
        {
            get
            {
                return this._ShipDate;
            }
            set
            {
                this._ShipDate = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Discount in the schema.
        /// </summary>
        public virtual System.Nullable<double> Discount
        {
            get
            {
                return this._Discount;
            }
            set
            {
                this._Discount = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Product in the schema.
        /// </summary>
        public virtual string Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Price in the schema.
        /// </summary>
        public virtual System.Nullable<double> Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this._Price = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Quantity in the schema.
        /// </summary>
        public virtual System.Nullable<double> Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this._Quantity = value;
            }
        }
    }

}
