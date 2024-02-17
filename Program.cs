
        // Ввод размера массива
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        // Создание массива строк
        string[] originalArray = new string[size];
        Console.WriteLine("Введите элементы массива:");
// Заполнение массива строк
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            originalArray[i] = Console.ReadLine();
        }
 // Фильтрация массива
        string[] filteredArray = FilterStrings(originalArray);

        // Вывод результата
        Console.WriteLine("Результирующий массив:");
        foreach (string str in filteredArray)
        {
            Console.WriteLine(str);
        }
    

    
        