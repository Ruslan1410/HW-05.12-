// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            // и возвращает значение этого элемента или же указание, что такого элемента нет.


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
                Console.WriteLine(" ]");
            }
            
            Console.Write("\nEnter rows for value: ");
            rows = int.Parse(Console.ReadLine()!);
            Console.Write("Enter columns for value: ");
            columns = int.Parse(Console.ReadLine()!);

            if (rows < 0 || rows >= matrix.GetLength(0)
                || columns < 0 || columns >= matrix.GetLength(1))
            {
                Console.WriteLine("Matrix has no this value");
            }
            else
            {
                Console.WriteLine(matrix[rows, columns]);
            }
