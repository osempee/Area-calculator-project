// See https://aka.ms/new-console-template for more information

using AreaShapes;
Console.WriteLine("Hello, World!");



double length = 8.1;
double width = 15;
double height = 25.5;
double Radius = 2;
double Base = 9;
double PI = 3.14;



double areaRectangle = length * width;
double AreaSquare = length * length;
double AreaTriangle = (Base * height) / 2;
double AreaCircle = (Radius * Radius * PI);
double AreaCube = (length * length * 6);
double AreaTrapezoid = (Base * Base) * height / 2;
double AreaParallelogram = (Base * height);
double AreaRhombus = (height * width) / 2;


Console.WriteLine("Area of a Rectangle: ");

Console.WriteLine(areaRectangle);

Console.WriteLine("Area of a Square: ");

Console.WriteLine(AreaSquare);

Console.WriteLine("Area of a Triangle: ");

Console.WriteLine(AreaTriangle);

Console.WriteLine("Area of a Circle: ");

Console.WriteLine(AreaCircle);

Console.WriteLine("Area of a Cube: ");

Console.WriteLine(AreaCube);

Console.WriteLine("Area of a Trapezoid: ");

Console.WriteLine(AreaTrapezoid);

Console.WriteLine("Area of a Parellelogram: ");

Console.WriteLine(AreaParallelogram);

Console.WriteLine("Area of a Rhombus: ");

Console.WriteLine(AreaRhombus);

Console.WriteLine("Welcome to my project select the shape you want to calculate the area");

Console.WriteLine("1. Rectangle \n 2. Square \n 3. Triangle \n 4. circle \n 5. Cube \n 6. Trapizoid \n 7. Paralelogram \n 8. Rhombus");

Console.WriteLine("Enter Option: ");

string? value = Console.ReadLine();

int option = Convert.ToInt32(value);

double area = 0;

switch (option)
{
    case 1:

        Console.Write("Enter Length of Rectangle: ");

        string? lengthStringRectangle = Console.ReadLine();

        double lengthRectangle = Convert.ToDouble(lengthStringRectangle);

        Console.Write("Enter Width of Rectangle: ");

        string? widthStringRectangle = Console.ReadLine();

        double widthRectangle = Convert.ToDouble(widthStringRectangle);

        area = Area.AreaOfRectangle(lengthRectangle, widthRectangle);

        break;

    case 2:

        Console.Write("Enter Length of Square: ");

        string? lengthStringSquare = Console.ReadLine();

        double lengthSquare = Convert.ToDouble(lengthStringSquare);

        area = Area.AreaOfSquare(length);


        break;

    case 3:

        Console.Write("Enter Base of Triangle: ");

        string? BaseStringTriangle = Console.ReadLine();

        double BaseTriangle = Convert.ToDouble(BaseStringTriangle);

        Console.Write("Enter height of Triangle: ");

        string? heightStringTriangle = Console.ReadLine();

        double heightTriangle = Convert.ToDouble(heightStringTriangle);

        area = Area.AreaOfTriangle(BaseTriangle, heightTriangle);

        break;

    case 4:

        Console.Write("Enter Radius of Circle: ");

        string? RadiusStringCircle = Console.ReadLine();

        double RadiusCircle = Convert.ToDouble(RadiusStringCircle);

        Console.Write("Enter PI of Circle: ");

        string? PIStringCircle = Console.ReadLine();

        double PICircle = Convert.ToDouble(RadiusStringCircle);

        area = Area.AreaOfCircle(RadiusCircle, PICircle);

        break;

    case 5:

        Console.Write("Enter Length of Cube: ");

        string? lengthStringCube = Console.ReadLine();

        double lengthCube = Convert.ToDouble(lengthStringCube);

        area = Area.AreaOfCube(lengthCube);

        break;

    case 6:

        Console.Write("Enter Base of Trapezoid: ");

        string? BaseStringTrapezoid = Console.ReadLine();

        double BaseTrapezoid = Convert.ToDouble(BaseStringTrapezoid);

        Console.Write("Enter height of Trapezoid: ");

        string? heightStringTrapezoid = Console.ReadLine();

        double heightTrapezoid = Convert.ToDouble(heightStringTrapezoid);

        area = Area.AreaOfTrapeziod(BaseTrapezoid, heightTrapezoid);

        break;

    case 7:

        Console.Write("Enter Base of Parallelogram: ");

        string? BaseStringParallelogram = Console.ReadLine();

        double BaseParallelogram = Convert.ToDouble(BaseStringParallelogram);

        Console.Write("Enter height of Parallelogram: ");

        string? heightStringParallelogram = Console.ReadLine();

        double heightParallelogram = Convert.ToDouble(heightStringParallelogram);

        area = Area.AreaOfParallelogram(BaseParallelogram, heightParallelogram);

        break;

    case 8:

        Console.Write("Enter height of Rhombus: ");

        string? heightStringRhombus = Console.ReadLine();

        double heightRhombus = Convert.ToDouble(heightStringRhombus);

        Console.Write("Enter Width of Rhombus: ");

        string? widthStringRhombus = Console.ReadLine();

        double widthRhombus = Convert.ToDouble(widthStringRhombus);

        area = Area.AreaOfRhombus(heightRhombus, widthRhombus);

        break;





}
Console.Write("This is area ");
Console.WriteLine(area);
















