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
            return (this.points[0].x - this.points[1].x) * (this.points[0].y - this.points[1].y);
        }
        public override double CalculatePerimeter()
        {
            return 2 * ((this.points[0].x - this.points[1].x) + (this.points[0].y - this.points[1].y));
        }
        public override string ToString()
        {
            return string.Format("{0} :  sides: {1}, {2} perimeter: {3},area: {4}", this.GetType().Name, Math.Abs(this.points[0].x - this.points[1].x), Math.Abs(this.points[0].y - this.points[1].y), this.CalculatePerimeter(), CalculateArea());
        }
    }
}
