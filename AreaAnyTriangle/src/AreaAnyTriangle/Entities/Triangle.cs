using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AreaAnyTriangle.Entities
{
    class Triangle
    {
        public double aSide { get; set; }
        public double bSide { get; set; }
        public double cSide { get; set; }

        public Triangle()
        {

        }

        public Triangle(double aSide, double bSide, double cSide)
        {
            this.aSide = aSide;
            this.bSide = bSide;
            this.cSide = cSide;
        }
        public double Area()
        {
            double p = Factor();
            return Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide));
        }

        private double Factor()
        {
            return (aSide + bSide + cSide) / 2;
        }
        public override string ToString()
        {
            return $"Area = {Area().ToString("F4", CultureInfo.InvariantCulture)}";
        }
    }
}
