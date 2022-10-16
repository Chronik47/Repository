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
