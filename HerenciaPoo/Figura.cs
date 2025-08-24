using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoo
{
    internal class Figura
    {
        public class Figure
        {
            #region
            public int positionX;
            public int positionY;


            public double CalculateArea()
            {
                return 0;
            }
            public double CalculatePerimeter()
            {
                return 0;
            }
            #endregion
        }
        public class Circule : Figure
        {
            private double radio;

            public Circule(double radio)
            {
                this.radio = radio;

            }
            public double CalculateArea()
            {
                double area = Math.PI * radio * radio;
                return area;
            }
            public double CalculatePerimeter()
            {
                double perimeter = 2 * Math.PI * radio;
                return perimeter;
            }
        }
        public class Triangle : Figure
        {
            private double basesTriangle;
            private double heightTriangle;
            private double side1,side2,side3;
           
            public Triangle(double basesTriangle, double heightTriangle, double side1, double side2, double side3)
            {
                this.basesTriangle = basesTriangle;
                this.heightTriangle = heightTriangle;
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;

            }
            public double CalculateArea()
            {
                double area = (basesTriangle * heightTriangle) / 2;
                return area;
            }
            public double CalculatePerimeter()
            {
                double perimeter = side1+side2+side3;
                return perimeter;
            }
        }
        public class Rectangle : Figure
        {
            private double basesRectangle;
            private double heightRectangle;

            public Rectangle(double basesRectangle, double heightRectangle)
            {
                this.basesRectangle = basesRectangle;
                this.heightRectangle = heightRectangle;
            }
            public double CalculateArea()
            {
                double area = basesRectangle * heightRectangle;
                return area;
            }
            public double CalculatePerimeter()
            {
                double perimeter = 2*(basesRectangle+heightRectangle);
                return perimeter;
            }
        }
        
    }
}
