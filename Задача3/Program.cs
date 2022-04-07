// Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.

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

int[,] ProizvMatrix(int[,] matrix1, int[,] matrix2)
{
    if(matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Операция невозможна. Не совпадают кол-во столбцов "+
                            "1й матрицы и строк 2й матрицы");
        int[,] nomatrix = new int[1,2];
        nomatrix[0,0] = matrix1.GetLength(1);
        nomatrix[0,1] = matrix2.GetLength(0);
        return nomatrix;
    }
    int rezult;
    int[,] matrixrezult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i < matrixrezult.GetLength(0); i++)
    {
        for(int j = 0; j < matrixrezult.GetLength(1); j++)
        {
            rezult = 0;
            for(int n = 0; n < matrix1.GetLength(1); n++)
            {
                rezult = rezult + matrix1[i, n] * matrix2[n, j];
                
            }
            matrixrezult[i,j] = rezult;
        }
        
    }
    return matrixrezult;
}

int[,] matrix1 = FillArray(2,3);
int[,] matrix2 = FillArray(3,2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(ProizvMatrix(matrix1, matrix2));

// matrix1[i, n] * matrix2[n, j] + matrix1[i, n+1] * matrix2[n+1,j]

//Произведение матрицы AA размера m×n и матрицы BB размера n×k — 
//это матрица CC размера m×k, 
//в которой элемент Cij равен сумме произведений элементов i 
//строки матрицы AA на соответствующие элементы j столбца матрицы 
//BB: Cij=Ai1B1j+Ai2B2j+...+Ain​Bnj​. 