﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 20.06.2012 18:29:09
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

namespace TPC
{

    /// <summary>
    /// There are no comments for TPC.Snake, TPC in the schema.
    /// </summary>
    public partial class Snake : Animal {

        private System.Nullable<decimal> _Length;

        private System.Nullable<bool> _IsVenomous;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Snake()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Length in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> Length
        {
            get
            {
                return this._Length;
            }
            set
            {
                this._Length = value;
            }
        }

    
        /// <summary>
        /// There are no comments for IsVenomous in the schema.
        /// </summary>
        public virtual System.Nullable<bool> IsVenomous
        {
            get
            {
                return this._IsVenomous;
            }
            set
            {
                this._IsVenomous = value;
            }
        }
    }

    /// <summary>
    /// There are no comments for TPC.Dog, TPC in the schema.
    /// </summary>
    public partial class Dog : Animal {

        private string _Breed;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Dog()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Breed in the schema.
        /// </summary>
        public virtual string Breed
        {
            get
            {
                return this._Breed;
            }
            set
            {
                this._Breed = value;
            }
        }
    }

    /// <summary>
    /// There are no comments for TPC.Animal, TPC in the schema.
    /// </summary>
    public abstract partial class Animal {

        private int _ID;

        private string _FoodClassification;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Animal()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        public virtual int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this._ID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for FoodClassification in the schema.
        /// </summary>
        public virtual string FoodClassification
        {
            get
            {
                return this._FoodClassification;
            }
            set
            {
                this._FoodClassification = value;
            }
        }
    }

}