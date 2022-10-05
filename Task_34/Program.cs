void Exit()
{
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
void Zadach34()
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    Console.Clear();
    int size = 10;
    int[] numbers = new int[size]; 
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    PrintEvevNumber(numbers);  
    
}
void FillArray(int[] numbers,     
               int minValue,
               int maxValue)
{
    maxValue++;                            
    int size = numbers.Length;
    Random random = new Random(); 
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
void PrintEvevNumber(int[] numbers)
{
    int count = 0;
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
   Console.WriteLine("Количество чётных элементов = " + count);
}
Zadach34();
Exit();