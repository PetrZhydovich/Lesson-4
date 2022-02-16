﻿// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillArray(int[] collection)//Эта функция заполняет массив
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col) //col=collection Эта функция выводит массив на экран
{
    int count = col.Length;
    int position = 0; //position=index
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[8]; //"создал новый массив в котором будет 8 элементов"

FillArray(array); //заполнил массив
PrintArray(array); //распечатал массив

