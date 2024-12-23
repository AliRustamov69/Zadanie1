using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> a = new List<int> { -1, 2, -3, 4, 5, 6, 12 };

        // Сумма положительных элементов
        int sumPositive = a.Where(x => x > 0).Sum();
        Console.WriteLine("Сумма положительных элементов: " + sumPositive);

        // Сумма элементов, которые больше единицы и меньше десяти
        int sumBetweenOneAndTen = a.Where(x => x > 1 && x < 10).Sum();
        Console.WriteLine("Сумма элементов больше единицы и меньше десяти: " + sumBetweenOneAndTen);

        // Сумма всех элементов
        int totalSum = a.Sum();
        Console.WriteLine("Сумма всех элементов: " + totalSum);
    }
}