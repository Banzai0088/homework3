﻿// See https://aka.ms/new-console-template for more information
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
// А (7,-5, 0); В (1,-1,9) -> 11,53
// int x1 = ReadInt("Введите х для точки 1: ");
// int y1 = ReadInt("Введите y для точки 1: ");
// int z1 = ReadInt("Введите z для точки 1: ");
// int x2 = ReadInt("Введите х для точки 2: ");
// int y2 = ReadInt("Введите y для точки 2: ");
// int z2 = ReadInt("Введите z для точки 2: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z2 - z1;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine("Расстояние = " + length);

// // Метод
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдает таблетку кубов числами от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125  */

// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube){
//   int counter = 0;
//   int length = cube.Length;
//   while (counter <  length){
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }

// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);