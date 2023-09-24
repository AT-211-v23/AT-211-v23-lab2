using System;

namespace AT_211_v23_lab2
{
    internal class Program
    {

        private static void Task1()
        {
            Random random = new Random();

            const int MinRange = 1;
            const int MaxRange = 12;

            int size = 10;
            double[] arr = new double[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(MinRange, MaxRange + 1);
            }

            double average_number = 0;
            for (int i = 0; i < size; i++)
            {
                Console.Write("   " + arr[i]);
                average_number += arr[i];
            }

            Console.Write("\nEnter position for replace >>");
            int position = Convert.ToInt32(Console.ReadLine());
            arr[position - 1] = average_number / size;

            for (int i = 0; i < size; i++)
            {
                Console.Write("   " + arr[i]);
            }
        }

        private static void Task2()
        {
            const int size = 10;
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            int[] finalArray = new int[size * 2];

            Random random = new Random();

            int pair_count = 0;

            for (int i = 0; i < size; i++)
            {
                int tmp1 = random.Next(1, 101);
                int tmp2 = random.Next(1, 101);

                arr1[i] = tmp1;
                arr2[i] = tmp2;

                if (tmp1 % 2 == 0) pair_count++;
                if (tmp2 % 2 == 0) pair_count++;
            }

            int pair_index = 0;
            int non_pair_index = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    finalArray[pair_index] = arr1[i];
                    pair_index++;
                }
                if (arr2[i] % 2 == 0)
                {
                    finalArray[pair_index] = arr2[i];
                    pair_index++;
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (arr1[i] % 2 != 0)
                {
                    finalArray[pair_count + non_pair_index] = arr1[i];
                    non_pair_index++;
                }
                if (arr2[i] % 2 != 0)
                {
                    finalArray[pair_count + non_pair_index] = arr2[i];
                    non_pair_index++;
                }
            }
            Console.WriteLine("Final array:");
            for (int i = 0; i < size * 2; i++)
            {
                Console.Write(finalArray[i] + " ");
            }
        }
        private static void Task3()
        {
            int[] start_arr = { 4, -5, 20, 0, 0, 7, 4, 0, 9, 0 };

            int count_number = 0;
            for (int i = 0; i < start_arr.Length; i++)
            {
                if (start_arr[i] != 0)
                {
                    count_number++;
                }
            }

            int[] final_arr = new int[count_number];
            int index = 0;

            for (int i = 0; i < start_arr.Length; i++)
            {
                if (start_arr[i] != 0)
                {
                    final_arr[index] = start_arr[i];
                    index++;
                }
            }

            Console.Write("\nStart arr >> ");
            Console.Write(string.Join(" ", start_arr));

            Console.Write("\nFinal array >> ");
            Console.Write(string.Join(" ", final_arr));
        }
        private static void Task4()
        {
            double[] array = { 7, 4.2, 2, 8, 5, 6 };
            bool flag_found = false;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] % i == 0 || array[i] == i)
                {
                    Console.WriteLine($"We found the first element {array[i]} that is equal to or a multiple of its index {i}.");
                    flag_found = true;
                    break;
                }
            }
            if (flag_found == false)
            {
                Console.WriteLine("Sorry, we can`t found ");
            }
        }

        private static void Task5()
        {
            Random random = new Random();

            const int MinMark = 1;
            const int MaxMark = 12;

            int size = 18;
            double[] arr = new double[size];

            double average_number1 = 0;
            double average_number2 = 0;
            double average_number3 = 0;

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(MinMark, MaxMark + 1);
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write("   " + arr[i]);
            }

            double tmp1 = 0;
            int counter1 = 0;
            double tmp2 = 0;
            int counter2 = 0;
            double tmp3 = 0;
            int counter3 = 0;

            for (int i = 0; i < size; i++)
            {
                if (i >= 0 && i <= 5)
                {
                    tmp1 += arr[i];
                    counter1++;
                }
                if (i >= 7 && i <= 12)
                {
                    tmp2 += arr[i];
                    counter2++;
                }
                if (i > 12)
                {
                    tmp3 += arr[i];
                    counter3++;
                }
            }

            average_number1 = tmp1 / counter1;
            average_number2 = tmp2 / counter2;
            average_number3 = tmp3 / counter3;

            Console.WriteLine();

            if (average_number1 > average_number2 && average_number1 > average_number3)
            {
                Console.WriteLine("  Better mark in 1 part ");
            }
            if (average_number2 > average_number1 && average_number2 > average_number3)
            {
                Console.WriteLine("  Better mark in 2 part ");
            }
            if (average_number3 > average_number1 && average_number3 > average_number2)
            {
                Console.WriteLine("  Better mark in 3 part ");
            }
        }

        private static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
    }
}
