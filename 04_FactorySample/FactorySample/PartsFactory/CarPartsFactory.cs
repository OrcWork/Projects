using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactorySample.Parts;

namespace FactorySample.PartsFactory
{
    public abstract class CarPartsFactory
    {
        public abstract Engine CreateEngine();
        public abstract Paint CreatePaint();
        public abstract Wheels CreateWheels();
    }
}
