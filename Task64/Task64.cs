/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();

int InputNumber(string Logo) // метод ввод числа
{
    int num;
    while (true)
    {
        Console.WriteLine(Logo);
        if (int.TryParse(Console.ReadLine(), out num))
            break;
        Console.WriteLine("Ошибка ввода");
    }
    return num;
}

int[] PrintRowNums(int[] arr, int num) // рекурсивный метод заполнения массива натуральными числами
{
    arr[arr.Length - num] = num;
    num -= 1;
    if (num > 0) return PrintRowNums(arr, num);
    else { return arr; }
}


void PrintPlusNumber(int[] array) // метод вывода на консоль информации
{
    Console.Write($"N = {array.Length} -> {String.Join(", ", array)}");
    Console.WriteLine();
}

int num = InputNumber("Введите число");
int[] array = new int[num];
array = PrintRowNums(array, num);
PrintPlusNumber(array);