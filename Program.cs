// //Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// // Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// //Method
// string GetRange(int min, int max)
// {
//     string s = string.Empty;
//     if (min > max) return s;
//     return (GetRange(min, max - 1) + max);
// }


// //Code
// Console.WriteLine("Задайте меньшее целое число m");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Задайте большее целое число n");
// int n = int.Parse(Console.ReadLine());
// Console.Write(GetRange(m, n));


// // Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
// // Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// // Method
// int GetSum(int min, int max)
// {
//     if (min > max) return 0;
//     return (GetSum(min, max - 1) + max);
// }


// //Code
// Console.WriteLine("Задайте меньшее целое число m");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Задайте большее целое число n");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Сумма натуральных элементов в промежутке от m до n:");
// Console.Write(GetSum(m, n));