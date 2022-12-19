//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//Например:
//78 -> 8
//12-> 2
//85 -> 8
int number1 = new Random().Next(10, 100);

Console.WriteLine(number1);

 if(number1 / 10 > number1 % 10) Console.WriteLine(number1/10);
 else Console.WriteLine(number1 % 10);

