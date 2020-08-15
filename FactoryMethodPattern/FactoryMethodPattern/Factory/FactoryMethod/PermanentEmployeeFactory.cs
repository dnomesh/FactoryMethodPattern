﻿using FactoryMethodPattern.Managers;
using FactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodPattern.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}