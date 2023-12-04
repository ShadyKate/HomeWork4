Console.Clear();
//Напишите программу, которая перевернёт одномерный массив 
void FillArray(int [] arrayMadeUp)
{
    for(int i = 0; i < arrayMadeUp.Length; i++)
    {
        arrayMadeUp[i] = new Random().Next(1, 101);
    }
}
void reverseArray(int [] arrayWeHave)
{
    for(int i = 0; i < arrayWeHave.Length / 2; i++)
    {
        int temp = arrayWeHave[i];
        arrayWeHave[i] = arrayWeHave[arrayWeHave.Length - i -1];
        arrayWeHave[arrayWeHave.Length - i - 1] = temp;
    }
}

Console.WriteLine("Введите колличество элементов массива: ");
int count = int.Parse(Console.ReadLine()!);
int [] array = new int [count];
FillArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
reverseArray(array);
Console.WriteLine($"Перевёрнутый массив: [{string.Join(", ", array)}]");