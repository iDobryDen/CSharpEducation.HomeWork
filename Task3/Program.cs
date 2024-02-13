using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        /*
        //многомерные массивы
        int[,,] matrix = new int[4, 6, 3];
        for (int i=0; i < 4; i++)
        {
            for (int j=0; j < 6; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    matrix[i, j, k] = new Random().Next();
                    Console.WriteLine(matrix[i, j, k]);
                }
            }
        }
        

        //массив массивов
        int[][] matrix = new int[3][];
        for (int i=0; i < matrix.GetLength(0); i++)
        {
            matrix[i] = new int[10];
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = i;
            }

        }
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix[i].Length; j++)
                Console.WriteLine(matrix[i][j]);
        */

        //Task3 Создайте двумерный массив чисел с плавающей точкой. Возведите элемент каждого подмассива в квадрат,
        //а затем подсчитайте сумму квадратов массива. Выведите на экран 2 числа.

        double[,] matrix = new double[,]
        {
            { 1.0, 2.1, 3.2, 4.5 },
            { 5.6, 6.7, 7.8, 8.9 }
        };

        double sum1 = 0;
        double sum2 = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            double sum3 = 0;//сумма квадратов подмассива
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum1 += matrix[i, j];//сумма двумерного массива
                matrix[i, j] = matrix[i, j] * matrix[i, j];
                sum2 += matrix[i, j];
                sum3 += matrix[i, j];  
            }
            Console.WriteLine("Сумма квадратов подмассива " + (i + 1) + ": " + sum3);
        }
        Console.WriteLine("Сумма двумерного массива равна: " + sum1 + ", а сумма квадратов двумерного массива: " + sum2);
    }
}

