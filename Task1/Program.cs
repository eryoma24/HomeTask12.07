//Задача 1: Задайте двумерный массив. Напишите программу, 
//которая упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int inputCountRow = CheckCorrectInputRowsAndColumns("Input count row => ");
int inputCountColumn = CheckCorrectInputRowsAndColumns("Input columns => ");
int inputRandomMin = ReadConsole("Input min random number => ");
int inputRandomMax = ReadConsole("Input max random number => ");

int[,] GenerateArray2D(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int CheckCorrectInputRowsAndColumns(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) return number;
    else
    {
        System.Console.WriteLine("Please input positive number!");
        return CheckCorrectInputRowsAndColumns(message);
    }
}

 

int[,] OrderByDescRowsElements(int[,] array)
{
    int i, j;
    Random random = new Random();
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

int[,] randomArray = GenerateArray2D(inputCountRow, inputCountColumn, inputRandomMin, inputRandomMax);
System.Console.WriteLine($"\nYours array => ");
PrintArray2D(randomArray);
System.Console.WriteLine();
System.Console.WriteLine($"\nArray with rows order by desc => ");
OrderByDescRowsElements(randomArray);
PrintArray2D(randomArray);
System.Console.WriteLine();