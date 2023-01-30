/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Задайте одномерный массив, заполненный случайными числами (в моём случае от -99 до 99).
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        array[i] = randome.Next(-99, 100);
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

int SumOddArrayElements(int[] sumArray)
{
    int sum = 0;
    for (int i = 1; i < sumArray.Length; i += 2)
    {
        sum += sumArray[i];
    }
    return sum;
}

Console.WriteLine("Программа генерирует заданный массив случайных чисел от -99 до 99.");
Console.WriteLine("После программа считает сумму элементов, стоящих на нечётных позициях.");
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
Console.WriteLine($"Сумма нечётных элементов массива = {SumOddArrayElements(randomArray)}");

Author();