/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/



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

int[] FillRowNums(int[] arr, int fnum, int snum) // рекурсивный метод заполнения массива числами
{
    arr[arr.Length - snum] = fnum;
    snum -= 1;
    fnum += 1;
    if (fnum <= arr.Length) return FillRowNums(arr, fnum, snum);
    else { return arr; }
}


void PrintPlusNumber(int[] array, int M, int N) // метод вывода на консоль информации
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    Console.WriteLine($"M = {M}; N = {N} -> {sum}");
    Console.WriteLine();
}

int fnum = InputNumber("Введите наименьшее M число");
int snum = InputNumber("Введите наибольшее N число");
int[] array = new int[snum];
array = FillRowNums(array, fnum, snum); // вызов рекурсивного метода заполнения массива
PrintPlusNumber(array, fnum, snum);