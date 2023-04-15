// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int [,] CreatArray(int m, int n)
{
    int [,] array = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random(). Next(0, 100);
        }
    }
    return array;
}

int ReadInt(string arg)
{
    System.Console.WriteLine(arg);
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
}





int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");

int[,] ArrayNew = CreatArray(m,n);
PrintArray(ArrayNew);
FindArif(ArrayNew);


void FindArif (int [,] ArrayNew)
{
for (int j = 0; j < ArrayNew.GetLength(1); j++)
{
    double arifmetic = 0;
    for (int i = 0; i < ArrayNew.GetLength(0); i++)
    {
        arifmetic += ArrayNew[i,j];
    }
    double arifmetic2 = arifmetic / m;
    System.Console.Write(Math.Round(arifmetic2,1) + " ");
}
}


