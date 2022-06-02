// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное
// 45 - 101101    3- 11    2- 10

// Console.Write("Введите число: ");
// int decnum = int.Parse(Console.ReadLine());

// void BinNum(int num)
// {
//     string binnum = "";
//     while (num > 0)
//     {
//         string text = (num % 2).ToString();
//         num = num / 2;
//         binnum = binnum + text;
//     }
//     char[] arr = binnum.ToCharArray(); // char - символ, разбиваем строку поэлементов - массив символов

//     Array.Reverse(arr);
//     var str = string.Join(" ", arr);
//     Console.WriteLine($"Число {decnum} в двоичном формате: {str}"); 
// }

// BinNum(decnum);

// чтобы не разворачивать массив
// Console.Write("Введите число: ");
// int decnum = int.Parse(Console.ReadLine());

// void BinNum(int num)
// {
//     string binnum = "";
//     while (num > 0)
//     {
//         string text = (num % 2).ToString();
//         num = num / 2;
//         binnum = text + binnum; // text пишем перед binnum чтобы развернуть сразу
//     }

//     Console.WriteLine(binnum);
// }

// BinNum(decnum);


// вариант преподавателя

Console.WriteLine("Введите десятичное число: ");
int numDec = int.Parse(Console.ReadLine());
Console.Write("Введите основание системы счисления: ");
int baseNum = int.Parse(Console.ReadLine());

int result = 0;
int d10 = 1;
while (numDec != 0)
{
    result = result + numDec % baseNum * d10;
    numDec /= 2; // numDec = numDec/=2 сокращенный вариант
    d10 = d10 * 10;
}
Console.WriteLine(result);





// для любой системы счисления через рекурсию
Console.WriteLine("Введите десятичное число: ");
int numDec = int.Parse(Console.ReadLine());
Console.Write("Введите основание системы счисления: ");
int baseNum = int.Parse(Console.ReadLine()); 
void DecToOther(int num, int baseN)
{
    if (num == 0)
    {
        return;
    }
    DecToOther(num / baseN, baseN);
    Console.Write(num % baseN);
}
DecToOther(numDec, baseNum);