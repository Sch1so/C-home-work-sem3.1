// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] RandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;

    return count;
}

Console.Write("Введите колличество элементов для генерации массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(size);
ShowArray(array);

int otvet = CountEvenNumbers(array);

Console.Write("В массиве четных значений -> " + otvet);

*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] RandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 101);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int SumNotEvenElements(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i +=2)
        sum += array[i];
    
    return sum;
}

Console.Write("Введите колличество элементов для генерации массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(size);
ShowArray(array);

int otvet = SumNotEvenElements(array);

Console.Write("Сумма не четных элементов равна -> " +otvet);

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] ArrayUser(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} массива ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

double DifferenceMaxMin( double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    double dif = max - min;
    return dif;
}

Console.Write("Введите колличество элементов для генерации массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = ArrayUser(size);
ShowArray(array);

double otvet = DifferenceMaxMin(array);
Console.Write("Разницу между максимальным и минимальным элементов массива -> " +otvet);

*/