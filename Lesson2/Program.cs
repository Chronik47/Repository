// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> no
// 12821 -> yes
// 23432 -> yes

// Console.Write("Введите число: ");
// string number = Console.ReadLine();

// void Check_Polindrom(string number)
// {
// 	if (number[0] == number[4] && number[1] == number[3])
// 	{
// 		Console.WriteLine("Число: {number} - Polindrom.");
// 	}
// 	else Console.WriteLine("Число: {number} - NOT a palindrome.");
// }
// 	Check_Polindrom(number);







// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double DistanceBetweenTwoPoints(double x, double x1, double y, double y1, double z, double z1)
// {
//     double num = 0;
//     num = (x1 - x)*(x1 - x) +
//            (y1 - y)*(y1 - y) +
//            (z1 - z)*(z1 - z);
//     num = Math.Sqrt(num);
//     return num;
// }

// Console.Write("Введите кординат x: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите кординат x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите кординат y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите кординат y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите кординат z: ");
// double z = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите кординат z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// double distanceBetweenTwoPoints = DistanceBetweenTwoPoints( x, x1, y, y1, z, z1);
// Console.WriteLine(distanceBetweenTwoPoints);

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubicNumbers(int num)

// {
//     int count = 1;
//     while(count <= num)
//     {
//         double n = Math.Pow(count, 3);
//         Console.Write(n + " ");
//         count++;
//     }
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// CubicNumbers(number);




// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int b = Convert.ToInt32(Console.ReadLine());

//     double n = Math.Pow(a, b);
// Console.WriteLine("Число " + n);




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (number > 0)
// {
// int ostatok = number % 10;
// number = number / 10;
// sum = sum + ostatok;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// m = 5 -> [1, 2, 5, 7, 19]

// m = 3 -> [6, 1, 33]

// int[] CreateArray()
// {
//     Console.Write("Введите длину создаваемого массива: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите данные {i + 1} элемента массива: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int[] myArray = CreateArray();
// ShowArray(myArray);


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     Console.WriteLine("Creating array: ");
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Input a {i + 1} element of array: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine("Complete!");
//     return array;
// }


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int AmountEvenNumbers(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//             count++;
//     }
//     return count;
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите min возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите max возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);

// int result = AmountEvenNumbers(myArray);
// Console.WriteLine($"Количество четных элементов " + result);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     Console.WriteLine("Creating array: ");
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Input a {i + 1} element of array: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine("Complete!");
//     return array;
// }


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int SumOddPositions(int[] array)
// {   
//     int sum = 0;
//     for(int i = 1; i < array.Length; i+=2)
//         sum += array[i];

//     return sum;
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите min возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите max возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);

// int result = SumOddPositions(myArray);
// Console.WriteLine($"Сумма элементов на нечётных позициях " + result);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] CreateArray()
{
    Console.Write("Введите длину создаваемого массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите данные {i + 1} элемента массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double MaxMinusMin (double[] array)
{
    double min, max;
    min = array[0];
    max = array[0];
      for(int i = 0; i < array.Length; i++)
      {
        if(array[i] < min)
          min = array[i];
        if(array[i] > max)
          max = array[i];
      }
      return max - min;
}

double[] myArray = CreateArray();
ShowArray(myArray);
double result = MaxMinusMin(myArray);
Console.WriteLine("Разница между минимальным и максимальным равна " + result);