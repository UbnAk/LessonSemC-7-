// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет

int [,] CreatArray(int m, int n)
{
    int [,] array = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random(). Next(-100, 100);
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

int poz1 = ReadInt("Введите номер строки в которой необходимо найти элемент:");
int poz2 = ReadInt("Введите номер столбца в которой необходимо найти элемент:");

if (poz1 <= m && poz2 <= n)
{
    int c = poz1 -1;
    int b = poz2 -1;
    System.Console.WriteLine($"Элемент находящиеся на {poz1} строке и {poz2} столбике  = {ArrayNew[c,b]}");
    
}
else
{
    System.Console.WriteLine("Такого элемента не существует:(");
}











// int FindElement(int [,] ArrayNew, int poz1, int poz2)
// {
//     for (int i = 0; i < ArrayNew.GetLength(0); i++)
//     {
//         for (int j = 0; j < ArrayNew.GetLength(1); j++)
//         {
//             if (i<= poz1 && j <= poz2)
//             {
//                 i = poz1;
//                 j = poz2;
//             }
//         }
//     }
// }

// int FindString(int [,] ArrayNew)
// {
//     System.Console.WriteLine("Введите номер строки: ");
//     return int.Parse(Console.ReadLine());
// }

// int FindColumn (int[,] ArrayNew)
// {
//     System.Console.WriteLine("Введите номер столбика: ");
//     return int.Parse(Console.ReadLine());
// }

