// // Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5. -> "1, 2, 3, 4, 5"
// // M = 4; N = 8. -> "4, 6, 7, 8"

// int[] arrayNumbers = new int[2];

// void EnterNumber(int[] array)
// {
//     bool isCorrectValue = false;
//     while (isCorrectValue == false)
//     {
//         Console.WriteLine("Enter first number");
//         int firstNumber = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter the second number greater than the first");
//         int secondNumber = Convert.ToInt32(Console.ReadLine());

//         if (secondNumber >= firstNumber)
//         {
//             array[0] = firstNumber;
//             array[1] = secondNumber;
//             isCorrectValue = true;
//         }
//         else
//         {
//             Console.WriteLine("You entered an incorrect range of numbers!");
//             Console.WriteLine("Try again:");
//         }
//     }
// }

// string GetValues(int firstNumber, int secondNumber)
// {
//     if (firstNumber == secondNumber) return firstNumber.ToString();
//     return (firstNumber + ", " + GetValues(firstNumber + 1, secondNumber));
// }

// void PrintValues()
// {
//     Console.WriteLine($"All natural numbers in the interval from {arrayNumbers[0]} : {arrayNumbers[1]} => {GetValues(arrayNumbers[0], arrayNumbers[1])}");
// }

// void Main()
// {
//     EnterNumber(arrayNumbers);
//     PrintValues();
// }

// Main();

// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


// int EnterParam(string msg)
// {
//     Console.Write(msg);
//     if (!int.TryParse(Console.ReadLine(), out var number))
//     {
//         Console.WriteLine("Ошибка ввода");
//         Environment.Exit(0);
//     }
//     return number;
// }

// int Subsequence(int numM, int numN)
// {
//     if (numM == numN) return numM;
//     else return numM + Subsequence(numM + 1, numN);
// }


// int numberM = EnterParam("Введите значение M: ");
// int numberN = EnterParam("Введите значение N: ");
// if (numberM > numberN)
// {
//     int temp = numberM;
//     numberM = numberN;
//     numberN = temp;
// }
// Console.WriteLine($"Сумма чисел от {numberM} до {numberN}  равна {Subsequence(numberM, numberN)}");


// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 29

// int EnterParam(string msg)
// {
//     Console.Write(msg);
//     if (!int.TryParse(Console.ReadLine(), out var number))
//     {
//         Console.WriteLine("Ошибка ввода");
//         Environment.Exit(0);
//     }
//     return number;
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Akkerman(m - 1, 1);
//     else return Akkerman(m - 1, Akkerman(m, n - 1));
// }


// int numberM = Math.Abs(EnterParam("Введите значение m: "));
// int numberN = Math.Abs(EnterParam("Введите значение n: "));
// Console.WriteLine($"Значение функции Аккермана для m={numberM} и n={numberN} равнo {Akkerman(numberM, numberN)}");