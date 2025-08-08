using UnityEngine;
using System;


namespace packagePuntos
{
    [Serializable]


    public class Punto2D
    {
        public double X;
        public double Y;

        public Punto2D() { }

        public Punto2D(double x, double y) { this.X = x; this.Y = y; }

        public double X1 { get => X; set => X = value; }
        public double Y1 { get => Y; set => Y = value; }
    }
}
