using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Mech
{
    class MechSystem
    {
        private Cool _cool;
        private Fight _fight;
        private Move _move;
        private Shoot _shoot;
        public MechSystem(Cool cool, Fight fight, Move move, Shoot shoot)
        {
            _cool = cool;
            _fight = fight;
            _move = move;
            _shoot = shoot;
        }

        public void LightMech()
        {
            _move.Movement(60);
            _move.Movement(50);
            _move.Movement(70);
            _shoot.Shooting(1);
            _move.Movement(50);
            _shoot.Shooting(1);
            _move.Stop();
            _cool.Cooling(10);
            _move.Movement(50);
            _move.Movement(60);
            _shoot.Shooting(2);
            _fight.Fighting();
        }
        public void HeavyMech()
        {
            _move.Movement(20);
            _move.Stop();
            _shoot.Shooting(4);
            _shoot.Shooting(3);
            _cool.Cooling(20);
            _move.Movement(30);
            _shoot.Shooting(2);
            _shoot.Shooting(2);
            _shoot.Shooting(3);
        }
    }
}
