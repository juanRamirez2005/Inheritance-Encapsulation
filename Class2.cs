using Encapsulamiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Point3D : PointEncapsulado
    {
        public int Z { get; set; }

        public void SetZ(int value)
        {
            if (value < 100)
                Z = value;

            else throw new ArgumentOutOfRangeException();
        }

        public int GetX()
        {
            return Z;
        }
    }
    
}
