// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.


int[] array = new int[8];
Random ArRandom = new Random();

for (int i = 0; i < array.Length; i++)
    {
        array[i] = ArRandom.Next(0,99);
        Console.Write("{0} ", array[i]);
    }