using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureHierarhy
{
    public class Circle : Shape
    {
        public Circle(List<sPoint> points)
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
            double radius = CalculatePointDistance();
            return Math.PI * radius * radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * CalculatePointDistance();
        }
        public override string ToString()
        {
            return string.Format("{0} : center:{1},{2} radius: {3}, perimeter: {4},area: {5}", this.GetType().Name, this.points[0].x, this.points[0].y, this.CalculatePointDistance(), CalculatePerimeter(), CalculateArea());
        }
    }
}
