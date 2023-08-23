// Закрашивание области

int[,] image = new int[,]
{
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0},
    {0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,1,1,1,1,1,1,1,1,0,0,0,0,0},
};

void PrintImage(int[,] imag)
{
    for (int i = 0; i < imag.GetLength(0); i++)
    {
        for (int j = 0; j < imag.GetLength(1); j++)
        {
            if (imag[i, j] > 0) Console.Write("+");
            else Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void PaintImage(int row, int column)
{
    if (image[row, column] == 0)
    {
        image[row, column] = 1;
        PaintImage(row - 1, column);
        PaintImage(row, column - 1);
        PaintImage(row + 1, column);
        PaintImage(row, column + 1);
    }
}

PrintImage(image);
Console.WriteLine();

PaintImage(8, 6);

PrintImage(image);
Console.WriteLine();
