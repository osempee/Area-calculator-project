using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapes
{
    public class Area
    {
        public static double AreaOfSquare(double length)
        {
            return length * length;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return (length * width);

        }

        public static double AreaOfTriangle(double Base, double height)
        {

            return (Base * height) / 2;
        }

        public static double AreaOfCircle(double Radius, double PI)
        {

            return (Radius * Radius * PI);
        }

        public static double AreaOfCube(double length)
        {


            return (length * length * 6);
        }

        public static double AreaOfTrapeziod(double Base, double height)

        {

            return (Base * Base) * height / 2;

        }

        public static double AreaOfParallelogram(double Base, double height)
        {

            return (Base * height);


        }

        public static double AreaOfRhombus(double height, double width)
        {

            return (height * width) / 2;



        }
    }
}
