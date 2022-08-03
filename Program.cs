﻿void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count)
    {
        Console.Write($"{col[position]},");
        position++;
    }
    Console.Write("\b]");
    Console.WriteLine();
}



void Task26() //Решение через логарифм
{
    Console.WriteLine("Enter number:");
    int number = Convert.ToInt32(Console.ReadLine());
    double log = Math.Log10(number);
    double count = Math.Floor(log) + 1;
    Console.WriteLine($"Number of digits = {count}");
}
// Task26();

void Task25()
{
    Console.WriteLine("Enter number:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter pow:");
    int pow = Convert.ToInt32(Console.ReadLine());
    int res = number;

    for (int i = 1; i < pow; i++)
    {
        res *= number;
    }
    Console.WriteLine($"Result = {res}");
}
//Task25();

void Task27()
{
    Console.WriteLine("Enter number:");
    int number = Convert.ToInt32(Console.ReadLine());
    double log = Math.Log10(number);
    double count = Math.Floor(log) + 1;
    int sum = 0;

    for (int i = 0; i < count; i++)
    {
        sum += number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Sum = {sum}");
}
//Task27();

void Task29()
{
    int size = 8;
    int[] array = new int[size];
    Random rand = new Random(); 
    for (int i = 0 ; i < size; i++)
    {
        array[i] = rand.Next(-99, 99);
    }

    for (int i = 0; i < array.Length; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[minPos]))
            {
                minPos = j;
            } 
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp; 
    }
    PrintArray(array);
}


Task29();