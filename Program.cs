// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 19 (branch task_1)
// Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, 
// является ли оно палиндромом.
//  	14212 -> нет
//  	12821 -> да
//  	23432 -> да
// Console.WriteLine ("Введите 5-ти значное число: ");
// string number = Console.ReadLine();
// int len = number.Length;
// if (len == 5)
// {
//     if (number[0] == number[4] && number [1] == number[3])
//     {
//         Console.WriteLine(number + "  является палиндром");
//     }

//     else
//     {
//         Console.WriteLine(number + "  не являетсяя палиндром");
//     }
// }
// else
// {
//     Console.WriteLine ("Вы ввели НЕ 5-и значное число");
// }
// Задача 21: Напишите программу, которая принимает вход в координаты двух точек и нахождение расстояния между ними в 3D-пространствах.
// А (3,6,8); В (2,1,-7), -> 15,84
// // А (7,-5, 0); В (1,-1,9) -> 11,53
// Console.WriteLine ("Введите х для точки 1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите y для точки 1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите z для точки 1: ");
// int zA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите х для точки 2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите y для точки 2: ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите z для точки 2: ");
// int zB = Convert.ToInt32(Console.ReadLine());

// double number = Math.Sqrt((Math.Pow((xA-xB),2))+(Math.Pow((yA-yB),2))+ (Math.Pow((zA-zB),2)));
// Console.WriteLine("Расстояние = " + number);
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдает таблетку кубов числами от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125  */

// Console.WriteLine("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// for (int count = 1; count <=cube; count++)
// {
//     Console.WriteLine (Math.Pow(count,3)+"");
// }