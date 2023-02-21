// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//Решение.

Console.Clear();

double[,] array = new double[3, 4];

GetArrayRealNumber(array);
PrintArray(array);

void GetArrayRealNumber(double[,] array) //Данный метод заполняет двухмерный массив вещественными числами.
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().NextDouble() * (-10 - 10) + 10; // NextDouble() дает случайное вещественное число в диапазоне от -10 до 10
    }
  }
}

void PrintArray(double[,] inArray) //Данный метод выводит на консоль массив.
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write("{0,6:G2}", inArray[i, j]); /* 0,6 - это расстояние между столбцами 
                                                G2 - это спецификатор форматов он содержит в себе два формата 
                                                Формат дробных чисел с фиксированной точкой, 
                                                указывает количество десятичных разрядов после запятой.
                                                Экспоненциальное представление числа, 
                                                указывает количество десятичных разрядов после запятой
                                                */

    }
    Console.WriteLine();
  }
}