// Console.Clear();

// Console.Write("Enter a number: ");

// int number = int.Parse(Console.ReadLine()!);

// int sqr = number * number;

// or like this, the result will be the same:
// int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
// Console.WriteLine($"Squareroot of the number {number} is equal to {sqr}");
// Console.WriteLine($"Squareroot of the number {number} is equal to {sqr1}");
// ///////////////////////////////////
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Пример: = 25, b = 5 -> да
// Console.WriteLine("Введите число А");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// if (b * b == a)
// {
// Console.WriteLine($"Является число {b} квадратом числа {a}");
// }
// else
// {
// Console.WriteLine($"Не является число {b} квадратом числа {a}");
// }
// ///////////////////////////////////
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Пример: 5 -> Пятница, 3 -> Среда.
// Console.Clear();

// Console.WriteLine("Если захотите выйти введите 100");

// int num;
// while(true){
// Console.Write("Введите номер дня недели: ");
// num = int.Parse(Console.ReadLine()!);
// // if(num == 1){
// Console.WriteLine("Понедельник");
// }
// else if (num == 2){
//     Console.WriteLine("Вторник");
// }
// else if (num == 3){
//     Console.WriteLine("Среда");
// }
// else if (num == 4){
//     Console.WriteLine("Четверг");
// }
// else if (num == 5){
//     Console.WriteLine("Пятница");
// }
// else if (num == 6){
//     Console.WriteLine("Суббота");
// }
// else if (num == 7){
//     Console.WriteLine("Воскресенье");
// }

// else if (num > 7){
//     Console.WriteLine("Не знаю такого дня недели");
// }
// //////////////////////////////////////////////////////
// Задача No5. Напишите программу, которая на вход принимает одно число (N),а на выходе показывает 
// все целые числа в промежутке от -N до N.
// Console.WriteLine("Введите число");

// int N = int.Parse(Console.ReadLine()!);
// int k = -N;
// while(k<=N)
// {
// Console.Write($"{k} ");
// k++;
// }
///////////////////////////////
// Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает последнюю цифру этого числа.
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// Console.WriteLine("Введите трехзначное число");
// int x = int.Parse(Console.ReadLine()!);
// int b = x % 10;
// Console.WriteLine(b);
// /////////////////////////////
