// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = a*x + b, a - gradient, b - intercept;


Console.Write("Enter first gradient: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter first intercept: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second gradient: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second interept: ");
double b2 = Convert.ToDouble(Console.ReadLine());

PrintArray(Intersection(k1, b1, k2, b2));

double[] Intersection(double k1, double b1, double k2, double b2)
{
    double[] inters = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    inters[0] = x;
    double y = k1 * x + b1;
    inters[1] = y;
    return inters;
}

void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {        
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}; ");
        }
    }
    Console.Write(")");
}

