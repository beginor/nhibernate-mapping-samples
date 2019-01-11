﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 14.06.2012 14:09:48
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

namespace ComponentID
{

    /// <summary>
    /// There are no comments for ComponentID.Employee, ComponentID in the schema.
    /// </summary>
    public partial class Employee {

        private int _EmployeeId;

        private string _Name;

        private DepartmentPhone _DepartmentPhone;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Employee()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for EmployeeId in the schema.
        /// </summary>
        public virtual int EmployeeId
        {
            get
            {
                return this._EmployeeId;
            }
            set
            {
                this._EmployeeId = value;
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
        /// There are no comments for DepartmentPhone in the schema.
        /// </summary>
        public virtual DepartmentPhone DepartmentPhone
        {
            get
            {
                return this._DepartmentPhone;
            }
            set
            {
                this._DepartmentPhone = value;
            }
        }
    }

    /// <summary>
    /// There are no comments for ComponentID.DepartmentPhone, ComponentID in the schema.
    /// </summary>
    public partial class DepartmentPhone {

        private DepartmentKeyType _DepartmentKey;

        private string _PhoneNumber;

        private string _Name;

        private Iesi.Collections.Generic.ISet<Employee> _Employees;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          DepartmentPhone toCompare = obj as DepartmentPhone;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.DepartmentKey, toCompare.DepartmentKey))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + DepartmentKey.GetHashCode();
          return hashCode;
        }
        
        #endregion

        public DepartmentPhone()
        {
            this._DepartmentKey = new DepartmentKeyType();
            this._Employees = new Iesi.Collections.Generic.HashedSet<Employee>();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for DepartmentKey in the schema.
        /// </summary>
        public virtual DepartmentKeyType DepartmentKey
        {
            get
            {
                return this._DepartmentKey;
            }
            set
            {
                this._DepartmentKey = value;
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
        /// There are no comments for Employees in the schema.
        /// </summary>
        public virtual Iesi.Collections.Generic.ISet<Employee> Employees
        {
            get
            {
                return this._Employees;
            }
            set
            {
                this._Employees = value;
            }
        }
    }

}

namespace ComponentID
{

    /// <summary>
    /// There are no comments for ComponentID.DepartmentKeyType, ComponentID in the schema.
    /// </summary>
    public partial class DepartmentKeyType {

        private int _DepartmentId;

        private int _PhoneID;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          DepartmentKeyType toCompare = obj as DepartmentKeyType;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.DepartmentId, toCompare.DepartmentId))
            return false;
          if (!Object.Equals(this.PhoneID, toCompare.PhoneID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + DepartmentId.GetHashCode();
          hashCode = (hashCode * 7) + PhoneID.GetHashCode();
          return hashCode;
        }
        
        #endregion

        public DepartmentKeyType()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for DepartmentId in the schema.
        /// </summary>
        public virtual int DepartmentId
        {
            get
            {
                return this._DepartmentId;
            }
            set
            {
                this._DepartmentId = value;
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
