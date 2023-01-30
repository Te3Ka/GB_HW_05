/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Задайте массив вещественных(?) чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
В примере указаны НАТУРАЛЬНЫЕ числа...
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
        array[i] = randome.Next(1, 100);
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

//Поиск разницы между макисмальным и минимальным элементами
void DifferenceMaxMinArray(int[] differenceArray)
{
    int min = differenceArray[0];
    int max = differenceArray[0];
    for (int i = 1; i < differenceArray.Length; i++)
    {
        if (min > differenceArray[i])
            min = differenceArray[i];
        else if (max < differenceArray[i])
            max = differenceArray[i];
    }
    Console.WriteLine($"Максимальное значение = {max}");
    Console.WriteLine($"Минимальное значение  = {min}");
    Console.WriteLine($"Разница между ними    = {max - min}");
}

Console.WriteLine("Программа генерирует заданный массив случайных чисел от 1 до 99.");
Console.WriteLine("После программа считает сумму элементов, стоящих на нечётных позициях.");
Console.Write("Введите количество элементов массива: ");
int.TryParse(Console.ReadLine(), out int num);
while (num <= 0)
{
    Console.WriteLine("Введено значение меньше 1, массив не может быть создан.\n"
                    + "Повторите ввод количества элементов массива:");
    int.TryParse(Console.ReadLine(), out num);
}
int[] maxMinArray = CreateRandomeArray(num);
PrintArray(maxMinArray);
DifferenceMaxMinArray(maxMinArray);

Author();