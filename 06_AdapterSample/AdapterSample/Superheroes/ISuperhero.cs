using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterSample.Superheroes
{
    interface ISuperhero
    {
        void Shoot();
        void Fly();
        void GoThrougWalls();
    }
}
