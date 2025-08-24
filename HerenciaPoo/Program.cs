// See https://aka.ms/new-console-template for more information


using static HerenciaPoo.Figura;

while (true)
{
    Console.WriteLine("¿Que figura deseas cálcular?");
    Console.WriteLine("1.Circulo");
    Console.WriteLine("2.Triangulo");
    Console.WriteLine("3.Rectangulo");
    Console.WriteLine("4.Salir");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingresa el radio del circulo:");
            double radio = double.Parse(Console.ReadLine());

            Circule circulo = new Circule(radio);

            Console.WriteLine("El Área del circulo es: " + circulo.CalculateArea());
            Console.WriteLine("El Perímetro del circulo es: " + circulo.CalculatePerimeter() + Environment.NewLine);

            break;
        case 2:
            Console.WriteLine("Ingresa la base del triangulo:");
            double basesTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la altura del triangulo:");
            double heightTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el lado 1 del triangulo:");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el lado 2 del triangulo:");
            double side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el lado 3 del triangulo:");
            double side3 = double.Parse(Console.ReadLine());

            Triangle triangulo = new Triangle(basesTriangle, heightTriangle, side1, side2, side3);

            Console.WriteLine("El Área del circulo es: " + triangulo.CalculateArea());
            Console.WriteLine("El Perímetro del circulo es: " + triangulo.CalculatePerimeter() + Environment.NewLine);
            break;
        case 3:
            Console.WriteLine("Ingresa la base del Rectangulo:");
            double basesRectangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la altura del Rectangulo:");
            double heightRectangle = double.Parse(Console.ReadLine());

            Rectangle rectangulo = new Rectangle(basesRectangle, heightRectangle);
            Console.WriteLine("El Área del circulo es: " + rectangulo.CalculateArea());
            Console.WriteLine("El Perímetro del circulo es: " + rectangulo.CalculatePerimeter() + Environment.NewLine);
            break;
        case 4:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opción incorrecta" + Environment.NewLine);
            break;

    }



}