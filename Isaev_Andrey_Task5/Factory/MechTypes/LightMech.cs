﻿using Factory.ModelsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.MechTypes
{
     class LightMech : Mech
    {
        private MechModelFactory _factory;
        public LightMech(MechModelFactory factory)
        {
            _factory = factory;
        }
        public override void TeamConfigurate()
        {
        Light = _factory.AddLightMech();
        }
    }
}
