/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

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

int FunOfAkkerman(int n, int m) // метод реализации функции Аккермана
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FunOfAkkerman(n - 1, 1);
    else
      return FunOfAkkerman(n - 1, FunOfAkkerman(n, m - 1));
}

//m = 2, n = 3 -> A(m,n) = 9
int m = InputNumber("Введите m число");
int n = InputNumber("Введите n число");
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {FunOfAkkerman(m,n)}"); // вывод на консоль результатов
