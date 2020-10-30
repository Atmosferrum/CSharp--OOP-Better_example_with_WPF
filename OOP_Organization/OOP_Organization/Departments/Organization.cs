﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Organization
{
    class Organization : Department
    {
        public Organization(string Name,
                            DateTime DateOfCreation,                            
                            string ParentDepartment)
            : base(Name,
                  DateOfCreation,
                  ParentDepartment)
        { }
    }
}
