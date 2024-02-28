//Задача 1. Определить, имеется ли в массиве случайных чисел элемент, значение которого равно значению первого элемента одномерного массива. Если такой элемент имеется, вывести на экран его порядковый номер. Массив состоит из шести элементов.
//int[] omus = new int[6];
//Random random = new Random();
//for (int i = 0; i < 5; i++)
//{
//    omus[i] = random.Next(0,10);
//    Console.Write($"{omus [i]}\t");
//}
//for (int x = 1; x < 5; x++)
//{
//    if (omus[0] == omus[x])
//    {
//        Console.Write($"\nПервый элемент равен значению {x+1} элемента");
//    }
//}
//Console.ReadKey();
//Задача 2. Дан одномерный массив. Вывести:
//а) все неотрицательные элементы;
//б) все элементы, не превышающие число 100;
//в) все четные элементы.
//int[] omus = new int[6];
//Random random = new Random();
//int chet;
//for (int i = 0; i < 5; i++)
//{
//    omus[i] = random.Next(-100, 100);
//    Console.Write($"{omus[i]}\t");
//}
//Console.WriteLine("\nЧисла соответствующие условию");
//foreach (int i in omus)
//{
//    if (i > 1 && i <= 100 && i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
//Console.ReadKey();
//Задача 3. Заполнить одномерный массив без использования клавиатуры следующими значениями: 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2. Подсчитать количество отрицательных элементов.
//int[] omus = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
//foreach (int i in omus)
//{
//    if (i < 0)
//    {
//        Console.WriteLine(i);
//    }
//}
//Console.ReadKey();
//Задача 4. Составьте программу вычисления среднего арифметического элементов с нечетными номерами.
int[] omus = new int[6];
Console.WriteLine("Введите 6 чисел:");
for (int i = 0; i <= 5; i++)
{
    int z = Convert.ToInt32(Console.ReadLine());
    omus[i] = z;
}
for (int i = 0;i <= 5;i++)
{
     if (i % 2 == 1)
    {
        Console.WriteLine((omus[i] + omus[i] + omus[i] + omus[i]) / 4 );
    }
}
