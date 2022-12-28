/*//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

 Console.WriteLine("Введите число: ");
 string number = Console.ReadLine()!;
 int len = number.Length;

 if (len == 5)
 {
     if (number[0] == number[4] && number[1] == number[3])
     {
         Console.WriteLine($"{number} - Палиндром");
     }
     else
     {
         Console.WriteLine($"{number} - НЕ палиндром");
     }
 }
 else
 {
     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
 }
 */
 //Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

 System.Console.Write("Введите коррдинату x точки А: ");
 int x1 = Convert.ToInt32(Console.ReadLine()); 
 System.Console.Write("Введите коррдинату y точки А: ");
 int y1 = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("Введите координату z точки A: ");
 int z1 = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("Введите коордианту x точки B: ");
 int x2 = Convert.ToInt32(Console.ReadLine()); 
 System.Console.Write("Введите коордианту y точки B: ");
 int y2 = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("Введите коррдинату z точки B: ");
 int z2 = Convert.ToInt32(Console.ReadLine()); 

 double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2)),2); 
 System.Console.WriteLine($"Расстояние между тремя точками: {result}");
