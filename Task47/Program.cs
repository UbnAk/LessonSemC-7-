// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9


double [,] CreatArray(int length1, int length2)
{
    double [,] array = new double [length1, length2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble() * 10, 1);
        }
    }
    return array;
}

int ReadInt()
{
    System.Console.WriteLine("Введите число: ");
    return int.Parse(Console.ReadLine());
}

void  PrintArray(double [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write(Array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

int length1 = ReadInt();
int length2 = ReadInt();
double [,] Array = CreatArray(length1, length2);
PrintArray(Array);
