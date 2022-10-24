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

// int[] CreateRandomArray()
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

// int[] myArray = CreateRandomArray();
// ShowArray(myArray);