//общий блок 

int[,] createRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}





//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8


int[,] MinToMaxInLine(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int m = j + 1; m < array.GetLength(1); m++)
            {
                if (array[i, j] < array[i, m])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, m];
                    array[i, m] = temp;
                }
            }
        }
    }
    return array;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = createRandom2dArray(m, n, 1, 9);
show2dArray(myArray);
Console.WriteLine();
show2dArray(MinToMaxInLine(myArray));





//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] createRectangularRandom2dArray(int rows, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, rows];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < rows; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

int MinSummLine(int[,] array)
{
    int temp;
    int temp2 = 0;
    int minline = 0;
    for (int j = 0; j < array.GetLength(1); j++) //сумма элементов первой строки, отправная точка
        temp2 += array[0, j];
    Console.WriteLine(temp2); //справочно - вывод суммы в строке
    for (int i = 1; i < array.GetLength(0); i++) //сравнение суммы первой строки с остальными строками и поиск наименьшей
    {
        temp = 0;
        for (int j = 0; j < array.GetLength(1); j++) //вычисление суммы элементов строки
            temp += array[i, j];
        Console.WriteLine(temp); //справочно - вывод суммы в строке
        if (temp < temp2)
        {
            minline = i; //запоминание строки с минимальной суммой
            temp2 = temp; //запоминание минимального числа для последующего сравнения
        }
    }
    return minline + 1;
}

Console.Write("Введите количество строк/столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] myArray = createRectangularRandom2dArray(m, 1, 9);
show2dArray(myArray);
Console.WriteLine();
double n = MinSummLine(myArray);
Console.WriteLine("Минимальная сумма элементов в строке номер " + n);





//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//и

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49

int[,] Multiplication2dArray(int[,] array, int[,] array2)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i, j] * array2[i, j];
        }
    }
    return array;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = createRandom2dArray(m, n, 1, 9);
show2dArray(myArray);
Console.WriteLine();
int[,] myArray2 = createRandom2dArray(m, n, 1, 9);
show2dArray(myArray2);
Console.WriteLine();
Console.WriteLine("Произведение элементов массивов:");
show2dArray(Multiplication2dArray(myArray, myArray2));







//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//массив размером 2 x 2 x 2
//12(0,0,0) 22(0, 0, 1)
//45(1, 0, 0) 53(1, 0, 1)

void show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i, j, k] + "(" + i + ", " + j + ", " + k + ") ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[] RandomArray(int rows, int columns, int rangs) //создание массива случайных неповторяющихся двухзначных чисел
{
    if (rows * columns * rangs > 90)
    {
        Console.WriteLine("чисел не хватает!");
        int[] array2 = Array.Empty<int>();
        return array2;
    }
    int[] array2d = new int[rows * columns * rangs];
    for (int i = 0; i < rows * columns * rangs; i++)
    {
        array2d[i] = new Random().Next(10, 100);
        int b = array2d[i];
        for (int j = 0; j < i; j++)
        {
            while (array2d[i] == array2d[j])
            {
                array2d[i] = new Random().Next(10, 100);
                j = 0;
                b = array2d[i];
            }
            b = array2d[i];
        }
    }
    return array2d;
}

int[,,] createRandom3dArrayNotRepeat(int[] array2d, int rows, int columns, int rangs) //заполнение 3д массива из массива метода RandomArray
{
    int[,,] newArray = new int[rows, columns, rangs];
    int l = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < rangs; k++)
            {
                newArray[i, j, k] = array2d[l];
                l++;
            }
        }
    }
    return newArray;
}

void showArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество рангов: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomArray(m, l, n);
//showArray(myArray);
show3dArray(createRandom3dArrayNotRepeat(myArray, l, m, n));






//Задача 62.Заполните спирально массив 4 на 4.

//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7


int[,] Spiral(int[,] arr)
{
    int x = arr.GetLength(1) - 1;
    int y = arr.GetLength(0) - 1;
    int a = 0;
    int sum = arr.GetLength(0) * arr.GetLength(1);
    int num = 1;
    int b = 0;

    while (num < sum)
    {
        for (int i = b; i < x; i++)
        {
            arr[a, i] = num;
            num++;
            if (num > sum) return arr;
        }
        for (int i = b; i < y; i++)
        {
            arr[i, x] = num;
            num++;
            if (num > sum) return arr;
        }
        for (int i = x; i > b; i--)
        {
            arr[y, i] = num;
            num++;
            if (num > sum) return arr;
        }
        for (int i = y; i > b; i--)
        {
            arr[i, a] = num;
            num++;
            if (num > sum) return arr;
        }
        if (num == sum)
        {
            arr[arr.GetLength(0) / 2, arr.GetLength(1) / 2] = num;
            return arr;
        }
        x--;
        y--;
        a++;
        b++;
    }
    return arr;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = createRandom2dArray(m, n, 1, 9);
Console.WriteLine();
show2dArray(Spiral(myArray));
