using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort_Advanced_Analysis
{
    class Program
    {
        //3 5 1 9 7 6 8 2 4
        //5 2 1 3 9 0 4 6 8 7
        private static int rez;


        static void Gnom(int[] numbers)
        {
            int i = 1;
            while (i < numbers.Length)
            {
                if (i == 0 || numbers[i - 1] <= numbers[i])
                    i++;
                else
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[i - 1];
                    numbers[i - 1] = temp;
                    i--;
                    rez++;
                }
            }
        }


        static void ChotnoNechotno(int[] numbers)
        {
            int counter = 0;  //schotchik nulevyh prohodov. Dlya vyhoda
            bool exit = false;
            int pereklyuchatel = 1;
            int i;
            int j;
            while (counter != 2)
            {
                if (pereklyuchatel % 2 == 0)
                {
                    i = 1;
                    j = 2;
                }
                else
                {
                    i = 0;
                    j = 1;
                }
                while (i < numbers.Length && j < numbers.Length)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                        rez++;
                        exit = true;
                        counter = 0;
                    }
                    i = j + 1;
                    j = i + 1;
                }

                pereklyuchatel++;

                if (exit == false)
                {
                    counter++;
                }
                exit = false;
            }
            Console.WriteLine(rez);
            rez = 0;
        }

        static void Raschoska(int[] numbers)
        {
            double gap = numbers.Length;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < numbers.Length)
                {
                    int igap = i + (int)gap;
                    if (numbers[i] > numbers[igap])
                    {
                        int swap = numbers[i];
                        numbers[i] = numbers[igap];
                        numbers[igap] = swap;
                        swaps = true;
                        rez++;
                    }
                    i++;
                }
            }
        }



        static void Sort(int[] numbers)
        {
            int j;
            int rez = 0;
            for (int k = 1; k < numbers.Length; k++)
            {
                j = k - 1;
                int i = k;
                while ((j >= 0) && (numbers[j] > numbers[i]))
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = temp;
                    rez++;
                    j--;
                    i--;
                }
            }
        }


        static void shellSort(int[] arr)
        {
            int j;
            int step = arr.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = tmp;
                        j -= step;
                        rez++;
                    }
                }
                step = step / 2;
            }
        }


        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
                    rez++;
                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

        public static int[] merge_sort(int[] up, int[] down, int start, int end)
        {
            if (start == end)
            {
                down[start] = up[start];
                return down;
            }


            int middle = (start + end) / 2;

            int[] leftArray = merge_sort(up, down, start, middle);
            int[] rightArray = merge_sort(up, down, middle + 1, end);

            // слияние двух отсортированных половин
            int[] target = leftArray == up ? down : up;

            int i = start;
            int j = middle + 1;
            for (int k = start; k <= end; k++)
            {
                if (i <= middle && j <= end)
                {
                    if (leftArray[i] < rightArray[j])
                    {
                        target[k] = leftArray[i];
                        rez++;
                        i++;
                    }
                    else
                    {
                        target[k] = rightArray[j];
                        rez++;
                        j++;
                    }
                }
                else if (i <= middle)
                {
                    target[k] = leftArray[i];
                    rez++;
                    i++;
                }
                else
                {
                    target[k] = rightArray[j];
                    rez++;
                    j++;
                }
            }
            return target;
        }

        public static void End(int[] elements)
        {
            int seredina = (0 + (elements.Length - 1)) / 2;
            int seredina_I = (0 + seredina) / 2;
            int seredina_II = (seredina + (elements.Length - 1)) / 2;

            Shejker(elements, 0, seredina_I);
            Shejker(elements, seredina_I, seredina);
            Shejker(elements, seredina, seredina_II);
            Shejker(elements, seredina_II, elements.Length);

            k = 0;
            Sliyanie(elements, 0, seredina, seredina_I);
            k++;
            Sliyanie(elements, seredina, elements.Length, seredina_II);
            k=0;
            elements = new int[sof.Length];
            SliyanieEnd(elements, 0, elements.Length, seredina);
        }

        static int[] sof;
        static int k;
        public static void Sliyanie(int[] elements, int start, int end, int seredina)
        {
            int i = start;
            int j = seredina;
            while (i < seredina && j < end)
            {
                if (elements[i] > elements[j])
                {
                    sof[k] = elements[j];
                    j++;
                }
                else
                {
                    sof[k] = elements[i];
                    i++;
                }
                k++;
            }
            if (j == end)
            {
                sof[k] = elements[i];
            }
            else
            {
                sof[k] = elements[j];
            }
        }


        public static void SliyanieEnd(int[] elements, int start, int end, int seredina)
        {
            int i = start;
            int j = seredina;

            while (i < seredina && j < end)
            {
                if (sof[i] > sof[j])
                {
                    elements[k] = sof[j];
                    //rez++;
                    j++;
                }
                else
                {
                    elements[k] = sof[i];
                    //rez++;
                    i++;
                }
                k++;
            }
            if (j == end)
            {
                elements[k] = sof[i];
            }
            else
            {
                elements[k] = sof[j];
            }
        }
        static void Shejker(int[] numbers, int start, int end)
        {
            int b = 0;
            int left = start;//Левая граница
            int right = end - 1;//Правая граница
            while (left < right)
            {
                for (int i = left; i < right; i++)//Слева направо...
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        b = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = b;
                        b = i;
                        rez++;
                    }
                }
                right = b;//Сохраним последнюю перестановку как границу
                if (left >= right) break;//Если границы сошлись выходим
                for (int i = right; i > left; i--)//Справа налево...
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        b = numbers[i];
                        numbers[i] = numbers[i - 1];
                        numbers[i - 1] = b;
                        b = i;
                        rez++;
                    }
                }
                left = b;//Сохраним последнюю перестановку как границу
            }
        }

        private static void Formula(int[] numbers)
        {

        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int length = int.Parse(Console.ReadLine());
                string[] str = Console.ReadLine().Split(' ');
                int[] num = str.Select(ch => int.Parse(ch.ToString())).ToArray();
                sof = new int[num.Length];
                rez = 0;
                //Sort(num);
                //Raschoska(num);
                //ChotnoNechotno(num);
                //Shejker(num,0,num.Length-1);
                //Gnom(num);
                //shellSort(num);
                //Quicksort(num, 0, num.Length - 1);
                //int[] second = new int[num.Length];
                //int[] k = merge_sort(num, second, 0, num.Length - 1);
                //End(num);
                Formula(num);
                Console.WriteLine(rez);
            }
        }
    }
}

//38046
//78149
//97560
//174498
//3083

//Один из вариантов ускорения сортировки – 
//использование параллельных вычислений при наличии нескольких процессоров.
//Целью лабораторной работы является реализация параллельного алгоритма сортировки 
//пузырьком и сравнение эффективности с последовательной сортировкой.