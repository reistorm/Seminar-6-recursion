// Не используя рекурсию вывести первые N чисел Фибоначчи
// Первые два числа Фибоначчи: 0 и 1
// Если N = 5, тогда 0 1 1 2 3
// Если N = 3, тогда 0 1 1 
// Если N = 7, тогда 0 1 1 2 3 5 8

int n = 0;
while (n < 2)
{
    Console.Write("Введите число N: ");
    n = int.Parse(Console.ReadLine());
}

void Fibonachi(int n)
{
    int[] fibarr = new int[n];
    fibarr[0] = 0;
    fibarr[1] = 1;
    for (int i = 2; i < n; i++)
    {
        fibarr[i] = fibarr[i - 1] + fibarr[i - 2];
    }
    var str = string.Join(" ", fibarr);
    Console.WriteLine($"Первые {n} чисел Фибоначчи: {str}");
}
Fibonachi(n);




