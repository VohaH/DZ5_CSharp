// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min,max);
    }
    return arr;
}



void CountNum(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0){
            count ++;
        }
    }
    Console.WriteLine($"Количество четных чисел в массиве = {count}");

}

int[] arr = FillArray(12, 100, 1000);
Console.WriteLine($"Массив : {string.Join(", ", arr)}");
CountNum(arr);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max);
    }
    return arr;
}

void SumNum(int[] arr){
    int sum= 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2 == 1){
            sum += arr[i];
        }
    }
    Console.WriteLine($"Ссумму элементов, стоящих на нечётных позициях = {sum}");

}

int[] arr = FillArray(12, 0, 10);
Console.WriteLine($"Массив : {string.Join(", ", arr)}");
SumNum(arr);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max) + rand.NextDouble();
    }
    return arr;
}

void SumNum(double[] arr){
    double dif = 0;
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max){
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    dif = max - min;
    Console.WriteLine($"Максимальный элемент = {max}\r\nМинимальный элемент = {min}\r\nРазница = {dif}");

}

double[] arr = FillArray(12, 0, 10);
Console.WriteLine($"Массив : {string.Join(", ", arr)}");
SumNum(arr);
