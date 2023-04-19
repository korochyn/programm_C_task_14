// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33-> [1, 2, 5, 7, 19, 6, 1, 33]

// Ввод числа с экрана

int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}
// Метод для получения случайных значений массива
int[] GenerateArray (int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for(int i=0; i < Length; i++)
    {
        array[i] = random.Next(minValue,maxValue+1);
    }
    return array;
}
// Метод вывода массива
void PrintArray (int [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}

int length = Promt("Длинна массива: ");
int min = Promt("Начальное значение для диапазона случайного числа: ");
int max = Promt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray (length, min, max);
PrintArray (array);