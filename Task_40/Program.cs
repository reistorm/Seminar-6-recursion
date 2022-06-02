// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник со 
// сторонами такой длины
// Теорема о неравенстве треугольника: каждая сторона
// треугольника меньше суммы двух других сторон

Console.WriteLine("Введите длину первой стороны: ");
int len1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны: ");
int len2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны: ");
int len3 = int.Parse(Console.ReadLine());

void Triangel(int L1, int L2, int L3)
{
    if (L1 + L2 > L3 && L1 + L3 > L2 && L2 + L3 > L1)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");

    }
}
Triangel(len1, len2, len3);


