// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void FindRowMin(int[,] array)
{
    int sumtemp = 0;
    int minrow = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        
        Console.WriteLine($"Строка {i+1} = {sum}");
        if(i == 0) sumtemp = sum;  // Очень долго думал как сделать красиво.
        if(sum < sumtemp)
        {
            sumtemp = sum;
            minrow = i;
        }
        
    }
    
    Console.WriteLine($"Наименьшая сумма элементов в {minrow+1}й строке.");

}

int[,] array = FillArray(4,4);
PrintArray(array);
FindRowMin(array);