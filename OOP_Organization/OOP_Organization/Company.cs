using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Organization
{
    struct Company
    {

        #region Fields;

        public static List<Department> departments;
        public static List<Employee> employees;

        private string name;
        
        private int numberOfDepartments;

        private int numberOfEmployees;

        private string dateOfCreation;

        #endregion Fields

        #region Constructor;

        public Company(string Name)
        {
            this.name = Name;
            departments = new List<Department>();
            employees = new List<Employee>();
            numberOfDepartments = 0;
            numberOfEmployees = 0;
            dateOfCreation = DateTime.Now.ToShortDateString();
        }

        #endregion Constructor


        #region Properties;

        public string Name
        {
            get { return this.name; }            
        }

        public int NumberOfDepartments
        {
            get { return this.numberOfDepartments; }
            set { this.numberOfDepartments = value; }
        }

        public int NumberOfEmployees
        {
            get { return this.numberOfEmployees; }
            set { this.numberOfDepartments = value; }
        }



        #endregion Properties

    }
}
