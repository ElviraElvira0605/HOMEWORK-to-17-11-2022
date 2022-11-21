// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
// Например:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;

class Program
{
    // Создание матрицы размера m x n,
    // заполненной случайными вещественными числами
    static double[,] CreateMatrix(int m, int n)
    {
        // Создание рандомизатора
        Random r = new Random();
        // Выделение памяти для матрицы
        double[,] matr = new double[m, n];
        // Цикл по всем строкам матрицы
        for (int i = 0; i < m; i++)
            // Цикл по всем столбцам матрицы
            for (int j = 0; j < n; j++)
                // r.NextDouble() создает случайное число от 0 до 1
                // r.NextDouble() * 20 создает случайное число от 0 до 20
                // r.NextDouble() * 20 - 10 создает случайное число от -10 до 10
                matr[i, j] = r.NextDouble() * 20 - 10;
        // Возврат полученной матрицы
        return matr;
    }

    // Вывод матрицы на экран
    static void Print(double[,] matr, int m, int n)
    {
        // Цикл по всем строкам матрицы
        for (int i = 0; i < m; i++)
        {
            // Цикл по всем столбцам матрицы
            for (int j = 0; j < n; j++)
                // Печать числа с сохранением 1 знака после запятой
                Console.Write($"{matr[i, j]:F1} ");
            // Переход на новую строку
            Console.WriteLine();
        }
    }

    // Основная программа
    static void Main()
    {
        // Ввод целого числа m
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        // Ввод целого числа n
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        // Создание матрицы
        double[,] matr = CreateMatrix(m, n);
        // Вывод матрицы
        Print(matr, m, n);
    }
}


