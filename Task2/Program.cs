//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int inputCountRow = CheckCorrectInputRowsAndColumns("Input count row => ");
int inputCountColumn = CheckCorrectInputRowsAndColumns("Input columns => ");
int inputRandomMin = ReadConsole("Input min random number => ");
int inputRandomMax = ReadConsole("Input max random number => ");
int [,] randomArray = GenerateArray2D(inputCountRow, inputCountColumn, inputRandomMin, inputRandomMax);

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

int SumElementsOfRows(int[,] array, int i)
{
    int j;
    int sum = array[i, 0];
    for (j = 0; j < array.GetLength(0); j++)
    {
        sum += array[i, j];
    }
    System.Console.WriteLine($"Sum of elements in row {i}: {sum} ");
    return sum;
}

System.Console.WriteLine($"\nYours array => ");
PrintArray2D(randomArray);
System.Console.WriteLine();
int minSumLine = 0;
int sumLine = SumElementsOfRows(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
    int tempSumLine = SumElementsOfRows(randomArray, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
System.Console.WriteLine($"\nRow number with the smallest sum of elements => {minSumLine}. Sum is => {sumLine}");