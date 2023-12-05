// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine()!);
            Console.Write("Enter columns: ");
            int columns = int.Parse(Console.ReadLine()!);
            int[,] matrix = new int[rows, columns];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine("]");
            }

            Console.WriteLine("\nResults\n");

            int last = matrix.GetLength(0)-1;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                (matrix[0, i], matrix[last, i]) = (matrix[last, i], matrix[0, i]);
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine("]");
            }
