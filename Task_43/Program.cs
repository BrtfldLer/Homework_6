// Программа найдет точку пересечения двух двух прямых, заданных уравнениями y=k1*x+b1; y=k2*x+b2
// Значения k, b вводятся пользователем
double numberX = 0;
double numberY = 0;
Console.WriteLine("Введите значение переменной k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение переменной b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение переменной k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение переменной b2");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
Console.WriteLine("Прямые не пересекаются");
}
else if (k1==k2 && b1!=b2)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
numberX = (b2-b1)/(k1-k2);
numberY = k1*numberX + b1;
Console.WriteLine($"Координаты точки пересечения двух прямых ({numberX},{numberY})");
}
