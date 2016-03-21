using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureHierarhy
{
    public class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;
        public Triangle(List<sPoint> points)
        {
            if (points == null)
            {
                throw new NullReferenceException();
            }
            if (points.Count != 3)
            {
                throw new InvalidOperationException();
            }
            this.points = this.DeepCopy(points);
            CalculateSides();
        }
        public bool ChangePoints(List<sPoint> points)
        {
            if (points == null)
            {
                throw new NullReferenceException();
            }
            if (points.Count != 3)
            {
                throw new InvalidCastException();
            }
            this.points = this.DeepCopy(points);
            CalculateSides();
            return true;
        }
        public override double CalculateArea()
        {
            double halphPerimeter = this.CalculatePerimeter() / 2;
            return Math.Sqrt(halphPerimeter * (halphPerimeter - side1) * (halphPerimeter - side2) * (halphPerimeter - side3));
        }
        public override double CalculatePerimeter()
        {
            return this.side1 + this.side2 + this.side3;
        }
        public override string ToString()
        {
            return string.Format("{0} :  sides: {1}, {2}, {3}, perimeter: {4},area: {5}", this.GetType().Name, this.side1, this.side2, this.side3, CalculatePerimeter(), CalculateArea());
        }
        private void CalculateSides()
        {
            this.side1 = CalculateDistanceBetweenTwoPoints(this.points[0], this.points[1]);
            this.side2 = CalculateDistanceBetweenTwoPoints(this.points[1], this.points[2]);
            this.side3 = CalculateDistanceBetweenTwoPoints(this.points[2], this.points[0]);
        }
    }
}
