// __________________Домашняя работа________________________

// __________________Задание 1______________________________

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("ВВедите число");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if  (number[0] == number[4] && number[1] == number [3])
//     {
//         Console.WriteLine("Да, палиндром");
//     }
//     else
//     {
//         Console.WriteLine("Нет, не палиндром");
//     }
// }
// else 
// {
//     Console.WriteLine("введите другое число");
// }



// ____________________Задание 2________________________

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите число X1");
// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число X2");
// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число Y1");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число Y2");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число X1");
// int Z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число X1");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((X2 - X1), 2)+ Math.Pow((Y2 - Y1), 2)+ Math.Pow((Z2 - Z1), 2)); // теорема Пифагора

// Console.WriteLine(d);


// _________________-Задание 3____________________________
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// if (num<count)
// {
//     Console.WriteLine("Введите еще раз");
// }

// while (num >= count)
// {
//     Console.Write(Math.Pow(count,3)+" ");
//     count++;
// }

