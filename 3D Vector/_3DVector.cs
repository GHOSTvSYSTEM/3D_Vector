using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Vector
{
    class _3DVector
    {
        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public _3DVector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public _3DVector Add(_3DVector other)
        {
            return new _3DVector(X + other.X, Y + other.Y, Z + other.Z);
        }
        public _3DVector Sub(_3DVector other)
        {
            return new _3DVector(X - other.X, Y - other.Y, Z - other.Z);
        }
        public double DotProduct(_3DVector other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }
        public _3DVector CrossProduct(_3DVector other)
        {
            return new _3DVector(
                Y * other.Z - Z * other.Y,
                Z * other.X - X * other.Z,
                X * other.Y - Y * other.X);
        }


        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }


    }

}
