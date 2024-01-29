//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
/*
Console.Clear();
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void rec(int m, int n)
{
    if (m > n)
    return;    
    {
        Console.Write($"{m}, ");
    }
   
    rec(m+1,n);

}
rec(m,n);

//Задача 2: Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n. 

Console.Clear();
Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int recAkkerman(int m, int n)
{
    if (m == 0) 
    return n + 1;
    else 
        if (n == 0) 
        return recAkkerman(m - 1, 1);
        else 
        return recAkkerman(m - 1, recAkkerman(m, n - 1));
}

Console.Write($" {recAkkerman(m, n)} ");

Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.  */



Console.Clear();
int[] array={1, 2, 5, 0, 10, 34};
Console.WriteLine(string.Join(", ", array));

void Print(int[] array, int i = 0)
{
    if(i != array.Length) 
    {
        Print(array, i + 1);
        Console.Write($"{array[i]}, ");
    }
}
    
Print(array);
