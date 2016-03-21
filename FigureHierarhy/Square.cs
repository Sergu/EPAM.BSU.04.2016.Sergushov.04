using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureHierarhy
{
    public class Square : Shape
    {
        public Square(List<sPoint> points)
        {
            if(points == null)
            {
                throw new NullReferenceException();
            }
            if(points.Count != 2)
            {
                throw new InvalidOperationException();
            }
            this.points = this.DeepCopy(points);
        }
        public bool ChangePoints(List<sPoint> points)
        {
            if(points == null)
            {
                throw new NullReferenceException();
            }
            if(points.Count!=2)
            {
                throw new InvalidCastException();
            }
            this.points = this.DeepCopy(points);
            return true;
        }
        public override double CalculateArea()
        {
            double diagonal = 2 * CalculatePointDistance();
            return diagonal * diagonal/2;
        }
        public override double CalculatePerimeter()
        {
            return 4 * Math.Sqrt(2) * CalculatePointDistance();
        }
        public override string ToString()
        {
            return string.Format("{0} : center:{1},{2} side: {3}, perimeter: {4},area: {5}", this.GetType().Name, this.points[0].x, this.points[0].y, this.CalculatePointDistance() / 2 * Math.Sqrt(2), CalculatePerimeter(), CalculateArea());
        }
    }
}
