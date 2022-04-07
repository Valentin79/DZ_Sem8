// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortArray(int[,] array)  //всего лишь час мозгового штурма и оно заработало как надо =)
{
    int temp;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int k = 0; k < array.GetLength(1); k++) //Цикл для сортировки строки полностью
        {
            for(int j = 0; j < array.GetLength(1)-1; j++)
            {
                if(array[i,j] < array[i, j+1])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                }
            }
        }
    }
    return array;
}

int[,] array = FillArray(3,7);
PrintArray(array);
Console.WriteLine();
PrintArray(SortArray(array));