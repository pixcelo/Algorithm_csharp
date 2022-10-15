using System;

namespace Algorithms.Service
{
    public class SortService
    {
        // Insertion sort
        public void InsertionSort()
        {
            var list = new List<int>() { 7, 2, 6, 9, 5 };

            for (int i = 1; i < list.Count; i++)
            {
                int tmp = list[i];
                int j;

                for (j = i - 1; j >= 0; j--)
                {
                    if (list[j] > tmp)
                    {
                        list[j + 1] = list[j];
                    }
                    else
                    {
                        break;
                    }
                }
                list[j + 1] = tmp;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public void BubbleSort()
        {
            var list = new List<int> { 30, 10, 40, 90, 70, 20, 80 };
            Console.WriteLine("before");
            list.ForEach(x => Console.Write($"{x} "));

            for (int i = list.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int tmp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = tmp;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("after");
            list.ForEach( x => Console.Write($"{x} "));
            Console.ReadKey();
        }

        public void ShellSort()
        {
            var list = new List<int>() { 10, 3, 1, 9, 7, 6, 8, 2, 4, 5 };
           
            for (int step = list.Count / 2; step > 0; step = step / 2)
            {
                int j;
                for (int i = step; i < list.Count; i++)
                {
                    int tmp = list[i];
                    for (j = i; j >= step; j -= step)
                    {
                        if (list[j - step] > tmp)
                        {
                            list[j] = list[j - step];
                        }
                        else
                        {
                            break;
                        }
                    }
                    list[j] = tmp;
                }
            }

            list.ForEach(x => Console.Write($"{x} "));
            Console.ReadKey();
        }

    }
}

