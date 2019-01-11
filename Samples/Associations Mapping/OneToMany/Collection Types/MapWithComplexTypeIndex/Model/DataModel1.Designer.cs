﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 22.06.2012 14:21:12
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

namespace MapWithComplexTypeIndex
{

    /// <summary>
    /// There are no comments for MapWithComplexTypeIndex.Employee, MapWithComplexTypeIndex in the schema.
    /// </summary>
    public partial class Employee {

        private int _EmployeeId;

        private string _FirstName;

        private string _LastName;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          Employee toCompare = obj as Employee;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.EmployeeId, toCompare.EmployeeId))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + EmployeeId.GetHashCode();
          return hashCode;
        }
        
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
        /// There are no comments for FirstName in the schema.
        /// </summary>
        public virtual string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this._FirstName = value;
            }
        }

    
        /// <summary>
        /// There are no comments for LastName in the schema.
        /// </summary>
        public virtual string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this._LastName = value;
            }
        }
    }

    /// <summary>
    /// There are no comments for MapWithComplexTypeIndex.Department, MapWithComplexTypeIndex in the schema.
    /// </summary>
    public partial class Department {

        private int _DepartmentId;

        private string _Name;

        private IDictionary<KeyType,Employee> _Employees;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          Department toCompare = obj as Department;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.DepartmentId, toCompare.DepartmentId))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + DepartmentId.GetHashCode();
          return hashCode;
        }
        
        #endregion

        public Department()
        {
            this._Employees = new Dictionary<KeyType,Employee>();
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
        public virtual IDictionary<KeyType,Employee> Employees
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

namespace MapWithComplexTypeIndex
{

    /// <summary>
    /// There are no comments for MapWithComplexTypeIndex.KeyType, MapWithComplexTypeIndex in the schema.
    /// </summary>
    public partial class KeyType {

        private string _LastName;

        private string _FirstName;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          KeyType toCompare = obj as KeyType;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.LastName, toCompare.LastName))
            return false;
          if (!Object.Equals(this.FirstName, toCompare.FirstName))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + LastName.GetHashCode();
          hashCode = (hashCode * 7) + FirstName.GetHashCode();
          return hashCode;
        }
        
        #endregion

        public KeyType()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for LastName in the schema.
        /// </summary>
        public virtual string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this._LastName = value;
            }
        }

    
        /// <summary>
        /// There are no comments for FirstName in the schema.
        /// </summary>
        public virtual string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this._FirstName = value;
            }
        }
    }

}