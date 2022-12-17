void FillArray(int[] nums, int minValue, int maxValue)
{
    Random rand = new Random();
    int length = nums.Length;
    maxValue++;
    for(int i=0; i<length; i++)
    {
        nums[i]=rand.Next(minValue,maxValue);
    }
    
}

void PrintArray(int[] nums)
{
    int length = nums.Length;
    Console.WriteLine("Вывод случайного массива:  ");
    for(int i=0; i<length; i++)
    {
        Console.Write((nums[i]) + " ");
    }
    Console.WriteLine();
}

void Zadacha34()
{
    Console.WriteLine();
    Console.WriteLine("Задача 34.");
    //Задача 34: Задайте массив заполненный случайными положительными 
    //трёхзначными числами. Напишите программу, которая покажет 
    //количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
    
    int size = 4; 
    int[] numbers = new int[size];
    
    FillArray(numbers, 100, 999); 
    PrintArray(numbers);

    int length = numbers.Length;
    int sumEven = 0;

    for(int i=0; i<length; i++)
    {
        if(numbers[i]%2==0)
        {
            sumEven += 1;
        }
    }
    Console.WriteLine($"Ответ: количество четных элементов массива =   {sumEven}");
    Console.WriteLine();
}

void Zadacha36()
{
    Console.WriteLine("Задача 36.");
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    //Найдите сумму элементов с нечётными индексами.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0
    
    int size = 4; 
    int[] numbers = new int[size];
    
    FillArray(numbers, -99, 99); 
    PrintArray(numbers);

    int length = numbers.Length;
    int sumOdd = 0;

    for(int i=0; i<length; i++)
    {
        if(i%2>0)
        {
            sumOdd += numbers[i];
        }
    }
    Console.WriteLine($"Ответ: сумма элементов с нечетными индексами равна =   {sumOdd}");
    Console.WriteLine();
}

void Zadacha38()
{
    Console.WriteLine("Задача 38.");
    //Задайте массив вещественных чисел. Найдите разницу между максимальным 
    //и минимальным элементов массива. [3,21 7,04 22,93 -2,71 78,24] -> 80,95 
        
    int size = 4; 
    double[] numbers = new double[size];
    int length = numbers.Length;
    
    Random rand = new Random();

    Console.WriteLine("Вывод случайного массива:  ");
    for(int i=0; i<length; i++)
    {
        numbers[i]=Math.Round(rand.NextDouble()*200-100, 2);
        Console.Write((numbers[i]) + " ");
    }
    Console.WriteLine();
       
    double max = numbers[0];
    double min = numbers[0];
    
    for(int i=0; i<length; i++)
    {
        if (numbers[i]>max) max = numbers[i];
        if (numbers[i]<min) min = numbers[i];      
    }
    double difference = Math.Round((max-min), 2);
    Console.WriteLine($"Ответ: разницу между максимальным и минимальным элементами массива равна =  {difference}");
    Console.WriteLine();
}

Zadacha34();
Zadacha36();
Zadacha38();

