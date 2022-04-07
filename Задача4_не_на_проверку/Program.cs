// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

// Возможно, я нагородил тут огород, но оно вроде работает =) Решение не для оценки,
// а на тему "а так можно было?". Все промежуточные выводы - закоммитил, в процессе 
// написания я по ним смотрел, что происходит и где программа сбивается.

// Да, есть проблемма нехватки чисел, решить несложно, но уже не в этот раз...

int ReplaceDouble(int[,,] array)  // Затыкаем дубли другим числом, отсутствующим в массиве
{
    //Console.WriteLine("НД");
    int plug = 10;
    for(int i = 0; i < array.GetLength(0); i++)  //Слой
        {
            for(int j = 0; j < array.GetLength(1); j++)  //Строка
            {
                for(int n = 0; n < array.GetLength(2); n++)  //Столбец
                {
                    if(array[i,j,n] == plug) 
                    {
                        plug++;
                        //Console.Write($">>{plug - 1} есть. ");
                        i = 0; j = 0; n = 0;
                    }
                    
                }
            }
        }
    //Console.WriteLine($"Возвращаю {plug}");
    return plug;
}

int[,,] CangeDoubleElement(int[,,] array)
{
    Random rnd = new Random();
    int itr = 1;
    foreach(int element in array)
    {
        int count = 1;
        for(int i = 0; i < array.GetLength(0); i++)  //Слой
        {
            for(int j = 0; j < array.GetLength(1); j++)  //Строка
            {
                for(int n = 0; n < array.GetLength(2); n++)  //Столбец
                {
                    
                    if(element  == array[i,j,n] && itr != count) // Второе условие что бы не сравнивать само с собой
                    {
                        //Console.Write($"/{element} = {array[i,j,n]}[{i},{j},{n}]");
                        array[i,j,n] = ReplaceDouble(array);
                        //Console.Write($" =>{array[i,j,n]}...");
                        //Console.WriteLine();
                        i = 0; j = 0; n=0; count = 1;
                        
                    }
                    //Console.WriteLine($"/{element} = {array[i,j,n]} / {count} / {itr}");
                    count++;
                    

                }
            }
        }
        //Console.WriteLine();
        //Console.WriteLine($"число {element} не найдено ({itr})");
        itr++;
    }
    Console.WriteLine();
    return array;
}

int[,,] FillArray(int x, int y, int z)
{
    
    int[,,] array = new int[x, y, z];
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)  //Слой
    {
        for(int j = 0; j < array.GetLength(1); j++)  //Строка
        {
            for(int n = 0; n < array.GetLength(2); n++)  //Столбец
            {
                array[i,j,n] = rnd.Next(10, 100);
                //foreach(int element in array)
                //{
                    //Console.Write($"{element}...");
                //}
                //Console.WriteLine();
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)  //Слой
    {
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
PrintArray(CangeDoubleElement(array));