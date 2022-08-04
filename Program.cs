void PrintArray(int[] col)
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

// Task29();

void fillArray(int[] collection)
{
    int size = collection.Length;
    Random rand = new Random(); 
    for (int i = 0 ; i < size; i++)
    {
        collection[i] = rand.Next(1, 51);
    }
}

// int[] arr = new int[5];
// fillArray(arr);
// PrintArray(arr);

int partition (int[] array, int start, int end)
{
    int temp;
    int marker = start;
    for ( int i = start; i < end; i++ ) 
    {
        if ( array[i] < array[end] )
        {
            temp = array[marker];
            array[marker] = array[i];
            array[i] = temp;
            marker += 1;
        }
    }
    temp = array[marker];
    array[marker] = array[end];
    array[end] = temp; 
    return marker;
}

void quicksort (int[] array, int start, int end)
   {
       if ( start >= end ) 
       {
           return;
       }
       int pivot = partition (array, start, end);
       quicksort (array, start, pivot-1);
       quicksort (array, pivot+1, end);
   }

// quicksort(arr, 0, 4);
// PrintArray(arr);

//Extra tasks

string ReverseString(string s)
    {
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
    }

void Task01()
{
    Console.WriteLine("Enter number:");
    int number = Convert.ToInt32(Console.ReadLine());
    string bin = Convert.ToString(number, 2);
    
    if (bin == ReverseString(bin))
    {
        Console.WriteLine($"Bin number {bin} is palindrom");
    }
    else Console.WriteLine($"{bin} is not palindrom");
}

// Task01();

void Task02()

{
    Random rand = new Random();
    int number = rand.Next(1, 11);
    int size = number * number;
    int[] arr = new int[size];
    int i = 0;

    while (i < number)
    {
        arr[rand.Next(0, size)] = 1;
        i++;
    }
    Console.WriteLine(size);
    PrintArray(arr);
}
// Task02();

void Task03()
{
    int size = 20;
    int[] arr = new int[size];
    fillArray(arr);
    PrintArray(arr);
    int maxFrq = 1;
    int maxS = arr[0];    

    for (int i = 0; i < size-1; i++)
    {
        int frq = 1;
        for (int j = i+1; j < size; j++)
        {
            if (arr[i] == arr[j])
            {
                frq++;
            }
        }
        if (frq > maxFrq)
        {
            maxFrq = frq;
            maxS = arr[i];
        }
    }
    if (maxFrq > 1)
    {
        Console.WriteLine($"Number {maxS} appears {maxFrq} times");     
    }
    else Console.WriteLine("All numbers unique");

}
Task03();
