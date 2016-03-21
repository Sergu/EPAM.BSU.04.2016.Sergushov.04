using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureHierarhy
{
    public class Rectangle : Square
    {

        public Rectangle(List<sPoint> points) : base(points)
        {

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
            return string.Format("{0} :  sides: {1}, {2} perimeter: {3},area: {4}", this.GetType().Name, this.points[0].x, this.points[0].y, this.CalculatePointDistance() / 2 * Math.Sqrt(2), CalculatePerimeter(), CalculateArea());
        }
    }
}
