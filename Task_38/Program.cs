void Exit()
{
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
void Zadach38()
{
    //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    Console.Clear();
    int size = 5;
    double [] numbers = new double[size]; 
    FillArrayDouble(numbers, -10, 10);
    PrintArrayDuble(numbers);
    PrintDifferenceMaxMinArray(numbers);
    
}
void FillArrayDouble(double[] numbers, int minValue, int maxValue)
{
    maxValue++;                            
    int size = numbers.Length;
    Random random = new Random(); 
    for (int i = 0; i < size; i++)
    {
        double value = random.NextDouble() * 10;
        numbers[i] = Math.Round(value, 2);
    }
}
void PrintArrayDuble(double[] numbers)
{
    int size = numbers.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
void PrintDifferenceMaxMinArray(double[] numbers)
{
    int size = numbers.Length;
    double max = numbers[0];
    double min = numbers[0];
    Console.Write("Разницу между максимальным и минимальным элементов массива = ");
    for(int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max) {max = numbers[i];}
        if (numbers[i] < min) {min = numbers[i];}
    }
    {
        Console.WriteLine(Math.Round(max - min, 2));
    }
    Console.WriteLine();
}

Zadach38();
Exit(); 