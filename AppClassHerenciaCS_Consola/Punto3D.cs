using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClassHerenciaCS_Consola
{
    class Punto3D : Punto2D
    {
        protected double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        private double distance;

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public Punto3D() : base()
        {
            z = 0;
        }
        public Punto3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
            distance = Math.Sqrt(Math.Pow(x - y, 2));
        }
        public override string ToString()
        {
            return base.ToString() + " Z= " + distance + "  Distancia de X a Y = " + distance;
        }
    }
}
