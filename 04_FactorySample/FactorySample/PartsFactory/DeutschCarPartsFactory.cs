using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactorySample.Parts;

namespace FactorySample.PartsFactory
{
    public class DeutschCarPartsFactory : CarPartsFactory
    {
        public override Engine CreateEngine()
        {
            return new DieselEngine();
        }

        public override Paint CreatePaint()
        {
            return new WhitePaint();
        }

        public override Wheels CreateWheels()
        {
            return new BigWheels();
        }
    }
}
