using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.L.Problem
{
    internal class Car : Vehicle
    {
        public override void Park()
        {

        }

        public override void Land()
        {
            throw new NotImplementedException();
        }

        public override void TakeOff()
        {
            throw new NotImplementedException();
        }

        public override void Brake()
        {

        }
        public override void SpeedUp()
        {

        }
    }
}