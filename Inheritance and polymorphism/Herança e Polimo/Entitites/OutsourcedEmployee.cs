using System;
using System.Collections.Generic;
using System.Text;

namespace Herança_e_Polimo.Entitites
{
    class OutsourcedEmployee : Employee
    {

        public float AdditionalCharge;

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, float valuePerHour, float additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override float Payment()
        {
            return base.Payment() + 1.1f * AdditionalCharge;
        }

    }
}
