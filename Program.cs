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


/// решение препода
/// 
Start();

void Start()
{

    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("34) Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
        System.Console.WriteLine("36) Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
        System.Console.WriteLine("38) Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");
        
        switch (numTask)
        {
            case 0: return; break;

            case 34:
                Console.Clear();
                int[] startArray = GetArray(12, 100, 999);
                Console.WriteLine(String.Join(" ", startArray));
                Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(startArray)}");
                break;
            case 36:
                Console.Clear();
                startArray = GetArray(6, 0, 999);
                Console.WriteLine(String.Join(" ", startArray));
                Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(startArray)}");

                break;


            case 38:
                Console.Clear();
                double[] startArrayDouble = GetArrayDouble(6, 0, 999);
                Console.WriteLine(String.Join(" ", startArrayDouble));
                Console.WriteLine($"Разница = {GetDifference(startArrayDouble)}");
                break;
            default: System.Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        res[i] = rand.Next(minValue, maxValue + 1);
    }
    return res;
}

double[] GetArrayDouble(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    var randon = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round((randon.Next(minValue, maxValue) + randon.NextDouble()), 2); // 45 + 0.456854368
    }
    return res;
}

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.


int GetEvenCount(int[] array)
{
    int count = 0;
    //[4,5,6,14]
    foreach (int item in array)
    {
        if (item % 2 == 0) count++;
    }

    return count;
}


//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int GetSumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }

    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    // double min = 0;
    // double max = 0;
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}




int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

// int decNumber = GetNumber("dec");
// int otherSystem = GetNumber("System");
// System.Console.WriteLine(DecToNum(decNumber, otherSystem));

string DecToNum(int decNumber, int otherSystem = 2)
{
    if (otherSystem > 16 || otherSystem < 2)
        return "Такой системы исчисления не существует((!!!";


    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        res = nums[decNumber % otherSystem] + res;// res = "0" + "" ="0"  // res = "1"+ "0"
        decNumber /= otherSystem;//d=535
    }
    return res;
}