// // Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.


int[,,] FillArray(int x, int y, int z)
{
    int temp = 10;
    int[,,] array = new int[x, y, z];
    
    for(int i = 0; i < array.GetLength(0); i++)  //Слой
    {
        for(int j = 0; j < array.GetLength(1); j++)  //Строка
        {
            for(int n = 0; n < array.GetLength(2); n++)  //Столбец
            {
                array[i,j,n] = temp;
                temp++;     // только "неповторяющиеся", а не "случайные неповторяющиеся"
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)  //Слой
    {
        Console.WriteLine($"Слой {i+1}");
        for(int j = 0; j < array.GetLength(1); j++)  //Строка 
        {
            for(int n = 0; n < array.GetLength(2); n++)  //Столбец
            {
                Console.Write($"{array[i,j,n]} [{i},{j},{n}] ");
            }
            Console.WriteLine();  
        }
        Console.WriteLine();
    }
}

int[,,] array = FillArray(3,3,3);
PrintArray(array);