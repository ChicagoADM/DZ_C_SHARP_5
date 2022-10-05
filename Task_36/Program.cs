void Exit()
{
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
void Zadach36()
{
    //Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
    Console.Clear();
    int size = 5;
    int[] numbers = new int[size]; 
    FillArray(numbers, 1, 10);
    PrintArray(numbers);
    PrintSumOddNumber(numbers);  
    
}
void FillArray(int[] numbers, int minValue, int maxValue)
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
void PrintSumOddNumber(int[] numbers)
{
    int sum = 0;
    int size = numbers.Length;
    for (int i = 1; i < size; i +=2 )
    {
        sum += numbers[i];
    }
   Console.WriteLine("Cумму элементов с нечётными индексами = " + sum);
}
Zadach36();
Exit(); 