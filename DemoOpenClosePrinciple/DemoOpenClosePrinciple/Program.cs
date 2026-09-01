

using DemoOpenClosePrinciple;

AreaCalculator calculator = new AreaCalculator();

Circle circle1 = new Circle();
circle1.Radius = 2;

Circle circle2 = new Circle();
circle2.Radius = 3;


Square square1 = new Square();
square1.Size = 5;

Square square2 = new Square();
square2.Size = 4;


Triangle triangle1 = new Triangle();
triangle1.Base = 5;
triangle1.Heigh = 2;

Triangle triangle2 = new Triangle();
triangle2.Base = 4;
triangle2.Heigh = 3;


Elipse elipse1 = new Elipse();
elipse1.MajorAxis = 3;
elipse1.MinorAxis = 2;

Elipse elipse2 = new Elipse();
elipse2.MajorAxis = 5;
elipse2.MinorAxis = 1;


Trapeze trapeze1 = new Trapeze();
trapeze1.LargerBase = 5;
trapeze1.SmallerBase = 4;
trapeze1.Heigh = 7;

Trapeze trapeze2 = new Trapeze();
trapeze2.LargerBase = 7;
trapeze2.SmallerBase = 3;
trapeze2.Heigh = 11;


List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(square1);
shapes.Add(square2);
shapes.Add(triangle1);
shapes.Add(triangle2);
shapes.Add(elipse1);
shapes.Add(elipse2);
shapes.Add(trapeze1);
shapes.Add(trapeze2);

var resultTotalArea = calculator.TotalArea(shapes);

Console.WriteLine($"El área total es {resultTotalArea}");