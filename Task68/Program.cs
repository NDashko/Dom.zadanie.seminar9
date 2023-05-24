// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите начальное число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int n = Convert.ToInt32(Console.ReadLine());

int AckermanFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
return AckermanFunction(m, n);
}

Console.WriteLine($"Функция Аккермана для заданных чисел = {AckermanFunction(m, n)}");