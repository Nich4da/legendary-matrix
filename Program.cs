using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Enter '+' or '-' to perform matrix operation, or any other key to exit: ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operation == '+' || operation == '-')
            {
                Console.Write("Enter the size of the matrix: ");
                int size = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the value for the matrix: ");
                double value = Convert.ToDouble(Console.ReadLine());

                double[,] matrix = new double[size, size];

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j] = value;
                    }
                }

                double result = PerformMatrixOperation(matrix, operation);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                break;
            }
        }
    }

    static double PerformMatrixOperation(double[,] matrix, char operation)
    {
        double result = 0;

        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (operation == '+')
                {
                    result += matrix[i, j];
                }
                else if (operation == '-')
                {
                    result -= matrix[i, j];
                }
            }
        }

        return result;
    }
}
