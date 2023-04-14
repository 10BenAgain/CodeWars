using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class Sphere
    {
        public int Radius { get; set; }
        public int Mass { get; set; }

        public Sphere(int radius, int mass) { Radius = radius; Mass = mass; }
        public int GetMass() => Mass;
        public double GetVolume() => Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3), 5); 
        public double GetSurfaceArea() => Math.Round(4 * Math.PI * Math.Pow(Radius, 2), 5);
        public double GetDensity() => Math.Round(Mass / GetVolume(), 5);
       

    }
}
