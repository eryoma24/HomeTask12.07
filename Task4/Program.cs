// Напишите программу, которая заполнит спирально квадратный массив.

Console.Clear();
int inputDimensionArray = CheckCorrectInputRowsAndColumns("Input dimension for array => ");

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

int[,] FillSpiral(int demention)
{
    int[,] array = new int[demention, demention];
    int rowBeg = 0, rowFin = 0, columnBeg = 0, columnFin = 0;
    int row = 0;
    int column = 0;
    int stepNumber = 0;
    while (stepNumber < array.Length)
    {
        array[row, column] = stepNumber;
        if (row == rowBeg && column < demention - columnFin - 1)
        column++;
        else if (column == demention - columnFin - 1 && row < demention - columnFin - 1)
        row++;
        else if (row == demention - rowFin - 1 && column > columnBeg)
        column--;
        else
        row--;
        if((row == rowBeg + 1) && (column == columnBeg) && (columnBeg != demention - columnFin))
        {
            rowBeg++;
            rowFin++;
            columnBeg++;
            columnFin++;
        }
        stepNumber++;
    }
    return array;
}

