using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Organization
{
    struct Company
    {

        #region Variables;

        static List<Department> departments;

        #endregion Variables


        #region Fields;

        private string name;
        
        private int numberOfDepartments;

        #endregion Fields

        #region Constructor;

        public Company(string Name)
        {
            this.name = Name;
            departments = new List<Department>();
            numberOfDepartments = 0;
        }

        #endregion Constructor


        #region Properties;

        public string Name
        {
            get { return this.name; }            
        }

        public int NumberOfDepartments
        {            
            set { this.numberOfDepartments = value; }
        }



        #endregion Properties

    }
}
