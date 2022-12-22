
/*
ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ №6


Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
/*


Console.WriteLine("Введите количество элеменов массива: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Вывод массива: ");
for (int i = 0; i < array.Length; i++)
    Console.Write(array[i]);


int PositivNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sum++;
    }
    return sum;
}    
    
int result = PositivNumber(array);
Console.WriteLine();
Console.Write($"В данном массиве количество чисел > 0 = {result}");    
   */ 


/*
Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/



Console.WriteLine("введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"две прямые пересекутся в точке c координатами X: {x} Y: {y}"); 




