// Пример прямоугольного двумерного массива
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        // Проходим по каждой строке и считаем сумму её элементов
        for (int i = 0; i < rows; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < columns; j++)
            {
                currentSum += matrix[i, j];
            }

            // Сравниваем с текущим минимумом
            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRowIndex = i;
            }
        }

        // Вывести результат
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1}");
