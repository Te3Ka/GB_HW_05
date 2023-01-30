/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

//Создание случайного массива
int[] CreateRandomeArray(int num)
{
    int[] array = new int[num];
    Random randome = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randome.Next(100, 1000);
    }
    return array;
}

//Печать массива на экран
void PrintArray(int[] arrayPrint)
{
    Console.Write("Полученный массив: ");
    Console.Write("[");
    for (int index = 0; index < arrayPrint.Length; index++)
    {
        if (index == (arrayPrint.Length - 1))
            Console.WriteLine($"{arrayPrint[index]}]");
        else
            Console.Write($"{arrayPrint[index]}, ");
    }
}

//Подсчёт чётных чисел в массиве
int EvenNumbers(int[] evenArray)
{
    int count = 0;
    for (int i = 0; i < evenArray.Length; i++)
    {
        if (evenArray[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.WriteLine("Программа генерирует заданный массив случайных положительных трёхзначных чисел.");
Console.WriteLine("После программа считает количество чётных чисел в этом массиве");
Console.Write("Введите количество элементов массива: ");
int.TryParse(Console.ReadLine(), out int num);
while (num <= 0)
{
    Console.WriteLine("Введено значение меньше 1, массив не может быть создан.\n"
                    + "Повторите ввод количества элементов массива:");
    int.TryParse(Console.ReadLine(), out num);
}
int[] randomArray = CreateRandomeArray(num);
PrintArray(randomArray);
Console.WriteLine($"Количество чётных чисел в массиве = {EvenNumbers(randomArray)}");

Author();