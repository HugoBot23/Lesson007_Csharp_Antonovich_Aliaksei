// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Решение.

Console.Clear();

int[,] array = new int[4, 4];

getArray(array);
printArray(array);
Console.WriteLine();
arithmeticMean(array);



void getArray(int[,] arr) //Данный метод заполняет массив рандомными целыми числами.
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void arithmeticMean(int[,] length) //В данном методе нахожу сумму каждого столбца и среднее арифметическое каждого столбца.
{
  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.Write("Сумма каждого столбца: ");

  double[] result = new double[length.GetLength(1)]; //Здесь создаю одномерный массив, длинна массива составляет длину столбца.

  for (int i = 0; i < length.GetLength(0); i++)
  {
    double summ = 0;
    for (int j = 0; j < length.GetLength(1); j++)
    {
      summ += length[j, i]; //Здесь складываю каждый столбец.
    }
    Console.Write($"{summ} ");
    result[i] = Math.Round(summ / length.GetLength(1), 2); //Здесь делю сумму, полученную от каждого столбца и делю на длину столбца и округляю до 2.
  }
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine();
  Console.Write($"Среднее арифметическое каждого столбца: {String.Join(" ", result)}");
}

void printArray(int[,] inArray) //Данный метод выводит двухмерный массив.
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write($"{inArray[i, j]} ");
    }
    Console.WriteLine();
  }
}
Console.ForegroundColor = ConsoleColor.White;
