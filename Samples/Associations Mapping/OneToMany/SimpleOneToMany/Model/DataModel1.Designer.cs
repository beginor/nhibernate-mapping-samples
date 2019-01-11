﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 14.06.2012 15:34:05
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

namespace SimpleOneToMany
{

    /// <summary>
    /// There are no comments for SimpleOneToMany.Employee, SimpleOneToMany in the schema.
    /// </summary>
    public partial class Employee {

        private int _EmployeeId;

        private string _Name;

        private Department _Department;
    
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
        /// There are no comments for Department in the schema.
        /// </summary>
        public virtual Department Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                this._Department = value;
            }
        }
    }

    /// <summary>
    /// There are no comments for SimpleOneToMany.Department, SimpleOneToMany in the schema.
    /// </summary>
    public partial class Department {

        private int _DepartmentId;

        private string _Name;

        private Iesi.Collections.Generic.ISet<Employee> _Employees;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Department()
        {
            this._Employees = new Iesi.Collections.Generic.HashedSet<Employee>();
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