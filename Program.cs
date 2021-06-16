/*
 * Создано в SharpDevelop.
 * Пользователь: 123
 * Дата: 16.06.2021
 * Время: 23:01
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace pr3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Лабораторная работа 3.Вариант 5 - Выводит индексы всех максимальных элементов");
		 	Console.WriteLine("===============================");
		 	
		 	
			Console.Write("РАЗМЕР МАССИВА= " );
                var len = int.Parse(Console.ReadLine());
                var array = new int[len];
                int max=-1;
                for (int i = 0; i < array.Length; i++)
                	
                {
                    Console.Write("Элемент ("+i+") = ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("===============================");
                Console.WriteLine("ИНДЕКСЫ МАКСИМАЛЬНЫХ ЭЛЕМЕНТОВ");
                for (int i = 0; i < array.GetLength(0); i++)
    if (max <= array[i])
        max = array[i];
for (int i = 0; i < array.GetLength(0); i++)
    if (array[i] == max)
                 Console.WriteLine(i);
                Console.WriteLine("===============================");
                Console.WriteLine("Для продолжения нажмите любую клавишу....");
                Console.ReadKey(true);
	}
}
}