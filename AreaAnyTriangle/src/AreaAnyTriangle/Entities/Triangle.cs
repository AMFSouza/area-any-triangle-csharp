using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using AreaAnyTriangle.Entities.Exceptions;

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
            VerifyMeasure(aSide);
            this.bSide = bSide;
            VerifyMeasure(bSide);
            this.cSide = cSide;
            VerifyMeasure(cSide);

            if (!IsTriangle())
            {
                throw new TriangleMeasureException("Is not a triangle.");
                
            }

        }
        public double Area()
        {
            double p = Factor();
            return Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide));


        }

        private double Factor()
        {
            double p = (aSide + bSide + cSide) / 2;

            if (p <= 0.0)
            {
                throw new FactorZeroException("The factor p must be greater than zero");
            }

            return p;
        }
        public override string ToString()
        {
            return $"Area = {Area().ToString("F4", CultureInfo.InvariantCulture)}";
        }

        private bool IsTriangle()
        {
            bool measuresDefineTriangle = false;

            measuresDefineTriangle = aSide + bSide > cSide &&
                                     aSide + cSide > bSide &&
                                     bSide + cSide > aSide ? true : false;

            return measuresDefineTriangle;
        }

        private void VerifyMeasure(double measure)
        {
            if (measure <= 0.0)
            {
                throw new MeasuresException("measure must be greater than zero.");
            }
        }
    }
}
