using System;
class Program
{
    // Перевірка, чи всі сторони додатні
    static bool AreSidesPositive(double a, double b, double c)
    {
        return a > 0 && b > 0 && c > 0; }
    // Перевірка існування трикутника
    static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c &&
               a + c > b &&
               b + c > a;
    }
    // Обчислення периметра
    static double CalculatePerimeter(double a, double b, double c)
    {
        return a + b + c;
    }
    // Обчислення площі за формулою Герона
    static double CalculateArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    // Перевірка, чи є трикутник прямокутним
    static bool IsRightTriangle(double a, double b, double c)
    {
        return a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a;
    }
    // Визначення виду трикутника
    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Рівносторонній";
        }
        if (a == b || a == c || b == c)
        {
            return "Рівнобедрений";
        }
        if (IsRightTriangle(a, b, c))
        {
            return "Прямокутний";
        }
        return "Довільний";
    }
    static void Main()
    {
        // Введення сторін
        Console.Write("Введіть a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        // Перевірка додатності
        if (!AreSidesPositive(a, b, c))
        {
            Console.WriteLine("Сторони повинні бути додатними.");
            return;
        }
        if (!IsTriangle(a, b, c))
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
            return;
        }
        double perimeter = CalculatePerimeter(a, b, c);
        double area = CalculateArea(a, b, c);
        string type = GetTriangleType(a, b, c);

        Console.WriteLine();
        Console.WriteLine("Трикутник існує.");
        Console.WriteLine($"Периметр: {perimeter}");
        Console.WriteLine($"Площа: {area:F2}");
        Console.WriteLine($"Вид трикутника: {type}");
    }
}