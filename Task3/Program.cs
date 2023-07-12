// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
int inputCountRowArray1 = CheckCorrectInputRowsAndColumns("Input count row for array1 => ");
int inputCountColumnArray1 = CheckCorrectInputRowsAndColumns("Input count columns for array1 => ");
int inputCountRowArray2 = CheckCorrectInputRowsAndColumns("Input count row for array2 => ");
int inputCountColumnArray2 = CheckCorrectInputRowsAndColumns("Input count columns for array2 => ");
int inputRandomMin = ReadConsole("Input min random number => ");
int inputRandomMax = ReadConsole("Input max random number => ");
int[,] randomArray1 = GenerateArray2D(inputCountRowArray1, inputCountColumnArray1, inputRandomMin, inputRandomMax);
int[,] randomArray2 = GenerateArray2D(inputCountRowArray2, inputCountColumnArray2, inputRandomMin, inputRandomMax);

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


int ReadConsole(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] MultiplyArray(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[inputCountRowArray1, inputCountColumnArray2];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
    return resultArray;
}

System.Console.WriteLine($"\nYours array1 => ");
PrintArray2D(randomArray1);
System.Console.WriteLine($"\nYours array2 => ");
PrintArray2D(randomArray2);
System.Console.WriteLine();
int[,] multipleArray = MultiplyArray(randomArray1, randomArray2);
System.Console.WriteLine($"\nResult multiply array12 => ");
PrintArray2D(multipleArray);
System.Console.WriteLine();