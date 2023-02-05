namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Massivin uzunlugunu daxil et:");
            //int n = int.Parse(Console.ReadLine());
            //double[] realNumber = new double[n];

            ////Console.WriteLine(mass.Length);

            //for (int i = 0; i < realNumber.Length; i++)
            //{
            //    Console.Write($"realNumber[{i}]=");
            //    realNumber[i] = double.Parse(Console.ReadLine());
            //}

            //double sum = 0;
            //for (int i = 0; i < realNumber.Length; i++)
            //{
            //    sum += realNumber[i];
            //}

            //foreach (var item in realNumber)
            //{
            //    sum += item;
            //}

            //Console.WriteLine(sum);

            //double max = realNumber[0];
            //int maxIndex = 0;
            //int count = 0;
            //for (int i = 0; i < realNumber.Length; i++)
            //{
            //    //if (max < realNumber[i])
            //    //    max = realNumber[i];

            //    if (realNumber[maxIndex] <= realNumber[i])
            //    {
            //        maxIndex = i;
            //    }
            //}

            //for (int i = 0; i < realNumber.Length; i++)
            //{
            //    if (realNumber[i] == realNumber[maxIndex])
            //    { 
            //        count++; 
            //    }

            //    //if (count == 3)
            //    //{
            //    //    Console.WriteLine(i);
            //    //    break; 
            //    //}
            //}

            //Console.WriteLine(count);
            //12 10
            //int minIndex = 0, maxIndex = 0;

            //for (int i = 0; i < realNumber.Length; i++)
            //{
            //    if (realNumber[i] < realNumber[minIndex])
            //        minIndex = i;

            //    if (realNumber[i] > realNumber[maxIndex])
            //        maxIndex = i;
            //}

            //double tmp = realNumber[minIndex];
            //realNumber[minIndex] = realNumber[maxIndex];
            //realNumber[maxIndex] = tmp;

            //foreach (var item in realNumber)
            //{
            //    Console.Write(item + " ");
            //}

            int[,] mass = { { 12, 23, 86 }, { 3, 4, 85 } };
            int n=int.Parse(Console.ReadLine());    
            int[,] mass1 = new int[n, n];

            for (int i = 0; i < mass1.GetLength(0); i++)
            {
                for (int j = 0; j < mass1.GetLength(1); j++)
                {
                    Console.Write($"mass1[{i},{j}]=");
                    mass1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < mass1.GetLength(0); i++)
            {
                for (int j = 0; j < mass1.GetLength(1); j++)
                {
                    Console.Write($"{mass1[i, j],-5}");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < mass1.GetLength(0); i++)
            {
                int max = mass1[i, 0];

                for (int j = 0; j < mass1.GetLength(1); j++)
                {
                    if (max < mass1[i, j])
                        max = mass1[i, j];
                }

                Console.WriteLine(max);
            }


            //Console.WriteLine("alo".PadRight(20, '-'));
            //for (int i = 0; i < mass1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mass1.GetLength(1); j++)
            //    {
            //        if (i + j == n-1)
            //            Console.WriteLine($"{mass1[i, j],-5}");
            //    }
            //}


        }
    }
}