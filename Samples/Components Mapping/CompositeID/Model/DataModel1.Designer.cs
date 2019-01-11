﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
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

namespace CompositeID
{

    /// <summary>
    /// There are no comments for CompositeID.DepartmentPhone, CompositeID in the schema.
    /// </summary>
    public partial class DepartmentPhone {

        private DepartmentPhoneType _DepartmentPhoneID;

        private string _PhoneNumber;

        private string _DeptName;

        private string _Location;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          DepartmentPhone toCompare = obj as DepartmentPhone;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.DepartmentPhoneID, toCompare.DepartmentPhoneID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + DepartmentPhoneID.GetHashCode();
          return hashCode;
        }
        
        #endregion

        public DepartmentPhone()
        {
            this._DepartmentPhoneID = new DepartmentPhoneType();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for DepartmentPhoneID in the schema.
        /// </summary>
        public virtual DepartmentPhoneType DepartmentPhoneID
        {
            get
            {
                return this._DepartmentPhoneID;
            }
            set
            {
                this._DepartmentPhoneID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for PhoneNumber in the schema.
        /// </summary>
        public virtual string PhoneNumber
        {
            get
            {
                return this._PhoneNumber;
            }
            set
            {
                this._PhoneNumber = value;
            }
        }

    
        /// <summary>
        /// There are no comments for DeptName in the schema.
        /// </summary>
        public virtual string DeptName
        {
            get
            {
                return this._DeptName;
            }
            set
            {
                this._DeptName = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Location in the schema.
        /// </summary>
        public virtual string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this._Location = value;
            }
        }
    }

}

namespace CompositeID
{

    /// <summary>
    /// There are no comments for CompositeID.DepartmentPhoneType, CompositeID in the schema.
    /// </summary>
    public partial class DepartmentPhoneType {

        private int _DepartmentID;

        private int _PhoneID;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          DepartmentPhoneType toCompare = obj as DepartmentPhoneType;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.DepartmentID, toCompare.DepartmentID))
            return false;
          if (!Object.Equals(this.PhoneID, toCompare.PhoneID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + DepartmentID.GetHashCode();
          hashCode = (hashCode * 7) + PhoneID.GetHashCode();
          return hashCode;
        }
        
        #endregion

        public DepartmentPhoneType()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for DepartmentID in the schema.
        /// </summary>
        public virtual int DepartmentID
        {
            get
            {
                return this._DepartmentID;
            }
            set
            {
                this._DepartmentID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for PhoneID in the schema.
        /// </summary>
        public virtual int PhoneID
        {
            get
            {
                return this._PhoneID;
            }
            set
            {
                this._PhoneID = value;
            }
        }
    }

}
