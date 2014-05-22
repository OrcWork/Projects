using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSLesson3
{
    public abstract class Car
    {
        protected int _speed;
        protected string _type;

        public Car()
        {
            _speed = 0;
            _type = "noname";

        }
        public override string ToString()
        {
            return string.Format("Model: {0}; Max speed: {1}", _type, _speed);
        }

        public abstract void Drive();
    }

    public class Vaz : Car
    {
        public Vaz()
            :base()
        {
            _type="VAZ 2107";
        }

        public override void Drive()
        {
            _speed = 60;
        }
    }

    public class Lamborgini : Car, ITurbo
    {
        public Lamborgini()
            : base()
        {
            _type = "Gallardo";
        }
        public override void Drive()
        {
            _speed = 260;
        }
        public void Turbo()
        {
        }
    }

    public class Ferrari : Car, IExtendEngin
    {
        public Ferrari()
            : base()
        {
            _type = "Ferrari";
        }
        public override void Drive()
        {
            _speed = 240;
        }
        public void ExtendEngin()
        {
        }

    }
    interface ITurbo
    {
        void Turbo();
    }
    interface IExtendEngin
    {
        void ExtendEngin();
    }

    
}
