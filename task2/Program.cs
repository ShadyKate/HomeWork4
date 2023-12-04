Console.Clear();
int [] FillArray(int size)
{
    int [] array = new int [size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int [] arrayWeHave)
{
    for(int i = 0; i < arrayWeHave.Length; i++)
    {
        Console.Write(arrayWeHave[i] + " ");
    }
    Console.WriteLine();
}

void countOfEvenNumbers(int [] arrayWeHave)
{
    int count = 0;
    foreach(int element in arrayWeHave)
    {
        if(element % 2 == 0)
        {
            count++;
        }
    }
     Console.WriteLine($"Количество чётных чисел в массиве составляет {count}");
}

int arraySize = 10;
int [] arrayMadeUp = FillArray(arraySize);
PrintArray(arrayMadeUp);
countOfEvenNumbers(arrayMadeUp);