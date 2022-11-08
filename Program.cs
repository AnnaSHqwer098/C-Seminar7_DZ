//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Задача 47. 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

double[,] array = GetArrayDouble(rows, columns, -9, 10);
PrintArrayDouble(array);

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Задача 50. 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2*/

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] Array = GetArray(row, column, 50, 99);
PrintArray(Array);
Console.WriteLine();

Console.WriteLine("Введите индекс строки: ");
int IdxM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите индекс столбца: ");
int IdxN = int.Parse(Console.ReadLine()!);
Console.WriteLine();

if (IdxM >= row || IdxN >= column) Console.WriteLine("Такой позиции элемента в массиве нет!");
else 
    Console.WriteLine($"Элементом на заданной позиции в данном массиве является число {GetElement(Array, IdxM, IdxN)}");
Console.WriteLine();


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Задача 52. 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine();
int[,] ARray = GetArray(4, 5, 0, 9);
PrintArray(ARray);
Console.WriteLine();

GetAverage(ARray);
Console.WriteLine();



//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ МЕТОДЫ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

double[,] GetArrayDouble (int m, int n, int minValue, int maxValue){
    double[,] result = new double [m,n];
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            result[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}

void PrintArrayDouble (double[,] Array){
    for (int i = 0; i < Array.GetLength(0); i++){
        for (int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]:f1}  |  ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray (int m, int n, int minValue, int maxValue){
    int[,] result = new int [m,n];
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray (int[,] Array){
    for (int i = 0; i < Array.GetLength(0); i++){
        for (int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int GetElement (int[,] arr, int IndexR, int IndexC){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            if (i == IndexR && j == IndexC) 
            arr[IndexR,IndexC] = arr[i,j]; 
        }
    }
    return arr[IndexR,IndexC];
    
}

void GetAverage (int[,] arr){
    int sum = 0;
    double average = 0;
    for (int j = 0; j < arr.GetLength(1); j++){
        for (int i = 0; i < arr.GetLength(0); i++){
            sum += arr[i,j];
        }
        average = (double) sum / arr.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {j} = {average}");
        sum = 0;
    }
}


