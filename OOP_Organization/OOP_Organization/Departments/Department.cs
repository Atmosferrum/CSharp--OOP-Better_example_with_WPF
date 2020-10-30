using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Organization
{
    abstract class Department
    {
        #region Constructor;

        public Department(string Name,                       
                          string ParentDepartment)
        {
            this.name = Name;
            this.dateOfCreation = DateTime.Now;
            this.numberOfEmployees = 0;
            this.numberOfDepartments = 0;
            this.parentDepartment = ParentDepartment;
            employees = new List<Employee>();
            departments = new List<Department>();

            AddMeToCompany();
        }

        private void AddMeToCompany()
        {
            if(parentDepartment == Repository.company.Name)
            {
                Company.departments.Add(this);
                ++Repository.company.NumberOfDepartments;
            }
            else
            {
                Department father = Repository.departments.Find(item => item.Name == parentDepartment);
                father.departments.Add(this);
                ++father.numberOfDepartments;
                ++Repository.company.NumberOfDepartments;
            }
        }



        #endregion Constructor

        #region Fields;

        protected string name { get; set; }
        protected DateTime dateOfCreation { get; set; }
        public int numberOfEmployees { get; set; }
        protected int numberOfDepartments { get; set; }
        protected string parentDepartment { get; set; }
        protected List<Department> departments;
        public List<Employee> employees;

        #endregion Fields


        #region Properties;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime DateOfCreation
        {
            get { return this.dateOfCreation; }
        }

        public int NumberOfEmployees
        {
            get { return this.numberOfEmployees; }
            set { this.numberOfEmployees = value; }
        }

        public int NumberOfDepartments
        {
            get { return this.numberOfDepartments; }
            set { this.numberOfDepartments = value; }
        }

        public string ParentDepartment
        {
            get { return this.parentDepartment; }
            set { this.parentDepartment = value; }
        }

        #endregion Properties


        #region Methods;

        string print()
        {
            return $"{this.name,15}" +
                   $"{this.dateOfCreation,15}" +
                   $"{this.numberOfEmployees}";
        }

        //public virtual int CountEmployees()
        //{
        //    int count = 0;

        //    foreach (Employee emply in Repository.employees)
        //        if (emply.Department == Name)
        //            ++count;
        //    return count;
        //}

        //public virtual int CountDepartments()
        //{
        //    int count = 0;

        //    foreach (Department dept in Repository.departments)
        //        if (dept.ParentDepartment == Name)
        //            ++count;
        //    return count;
        //}

        #endregion Methods
    }
}
