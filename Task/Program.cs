using System;

class Program
{
    static void Main()
    {
        // Ввод массива с клавиатуры
        Console.Write("Введите элементы массива через запятую: ");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(',');

        // Вызов функции для фильтрации массива
        string[] newArray = FilterArray(originalArray);

        // Вывод результата
        Console.WriteLine("Новый массив: [" + string.Join(", ", newArray) + "]");
    }

    static string[] FilterArray(string[] inputArray)
    {
        // Подсчет количества элементов, удовлетворяющих условию
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива
        string[] newArray = new string[count];

        // Заполнение нового массива
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }

        return newArray;
    }
}
