// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1,7] -> по такому индексу нет элемента.

//Решение.

Console.Clear();

Console.WriteLine("Введите строку");
int numb1 = int.Parse(Console.ReadLine()!) - 1;
Console.WriteLine("Введите столбец");
int numb2 = int.Parse(Console.ReadLine()!) - 1;

int[,] array = new int[6, 8];
getArray(array);

void getArray(int[,] arr) //Данном методе заполняю массив рандомными числами и выводит результаты.
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(10, 50);
      Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
  }
  if (numb1 < 0 | numb1 > array.GetLength(0) - 1 | numb2 < 0 | numb2 > array.GetLength(1) - 1) //Здесь проверяю веденное число пользователем, если оно меньше нуля или больше длины массива по строкам и столбцам.
  {
    Console.WriteLine("[" + numb1 + "," + numb2 + "]" + " -> по такому индексу нет элемента");
  }
  else
  {
    Console.WriteLine("Значение элемента массива -> {0}", array[numb1, numb2]); // Здесь вывожу элемент массива который лежит по индексу заданным пользователем.
  }
}