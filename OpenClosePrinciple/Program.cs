using System;

namespace OpenClosePrinciple
{
    //Gelecek olan isteklerin sistemimize rahatlıkla entegre olabilmesi veya kolaylıkla genişletilebilmesi
    //için uygulamamızı gelişime açık, değişime kapalı bir şekilde geliştirmeliyiz.

    public abstract class Shape
    {
        public abstract double findArea();
    }

    public class Circle : Shape
    {
        public double radius { get; set; }

        public override double findArea()
        {
            return radius * radius * Math.PI;
        }
    }

    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public override double findArea()
        {
            return width * height;
        }
    }

    public class AreaCalculator
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.findArea();
            }

            return area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator calculator = new AreaCalculator();
            calculator.Area(new Shape[] { new Rectangle { height = 20, width = 10 }, new Circle { radius = 10 } });
        }
    }
}
