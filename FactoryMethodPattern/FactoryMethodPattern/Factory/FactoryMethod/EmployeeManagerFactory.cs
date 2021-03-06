﻿using FactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodPattern.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if(emp.EmployeeType == 1)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else if(emp.EmployeeType == 2)
            {
                returnValue = new ContractEmployeeFactory(emp);
            }
            return returnValue;
        }
    }
}