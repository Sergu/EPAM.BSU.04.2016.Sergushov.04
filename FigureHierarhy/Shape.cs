using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FigureHierarhy
{
    public struct sPoint
    {
        public double x;
        public double y;
        public sPoint(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public abstract class Shape
    {
        public List<sPoint> points
        {
            get
            {
                return DeepCopy(points);
            }
            private set;
        }
        virtual double CalculateArea();
        virtual double CalculatePerimeter();
        virtual string ToString()
        {
            return string.Format("{0} : perimeter: {4},area: {5}", this.GetType().Name, CalculatePerimeter(), CalculateArea());
        }
        public double CalculatePointDistance()
        {
            return CalculateDistanceBetweenTwoPoints(this.points[0],this.points[1]);
        }
        public double CalculateDistanceBetweenTwoPoints(sPoint point1,sPoint point2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(point1.x - point2.x), 2) + Math.Pow(Math.Abs(point1.y - point2.y), 2));
        }
        public bool ChangePoints(List<sPoint> points)
        {
            if (points == null)
            {
                throw new NullReferenceException();
            }
            this.points = this.DeepCopy(points);
            return true;
        }
        public List<sPoint> DeepCopy(List<sPoint> points)
        {
            if (points == null)
            {
                throw new NullReferenceException();
            }
            List<sPoint> copedList = new List<sPoint>();
            foreach(sPoint point in points)
            {
                sPoint newPoint = new sPoint(point.x,point.y);
                copedList.Add(newPoint);
            }
            return copedList;
        }
    }
}
