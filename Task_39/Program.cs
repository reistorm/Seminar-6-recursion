// Написать программу, которая перевернет
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [ 1 2 3 4 5]

Console.Write("Введите элементы массива через пробел: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
// Split - делит сроку (по пробелу или букве)
// Select(int.Parse) - конвентация в int из string
// ToArray - приводим к типу массива (т.к. select возвращает коллекцию)

Console.WriteLine(String.Join(" ", array));
int size = array.Length;
int index1 = 0;
int index2 = size - 1;

while (index1 < index2)
{
    int temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;

    index1++;
    index2--;
}
Console.WriteLine(String.Join(" ", array));
