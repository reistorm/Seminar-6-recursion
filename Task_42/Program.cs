// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное
// 45 - 101101    3- 11    2- 10

Console.Write("Введите число: ");
int decnum = int.Parse(Console.ReadLine());

void BinNum(int num)
{
    string binnum = "";
    while (num > 0)
    {
        string text = (num % 2).ToString();
        num = num / 2;
        binnum = binnum + text;
    }
    char[] arr = binnum.ToCharArray(); // char - символ, разбиваем строку поэлементов - массив символов

    Array.Reverse(arr);
    var str = string.Join(" ", arr);
    Console.WriteLine($"Число {decnum} в двоичном формате: {str}"); 
}

BinNum(decnum);
