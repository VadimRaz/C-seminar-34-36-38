﻿// // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int[8];
Random rand = new Random(); // random - это тип переменной как string, double, bool...
for (int i = 0, i < array.Length; i++)
{
    array [i] = rand.Next(0,2);
    // Console.WriteLine($"{array[i]}");
}
Console.WriteLine (string.Join(", ", array));
