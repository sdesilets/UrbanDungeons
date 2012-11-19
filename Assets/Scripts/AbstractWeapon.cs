using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class AbstractWeapon
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Range ThrustDamage { get; set; }
        public Range SwingDamage { get; set; }
    }
}
