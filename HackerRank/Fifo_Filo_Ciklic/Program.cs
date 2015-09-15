using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Filo_Ciklic
{
    public class RoundArray<T>
    {
        private T[] numbers;
        private int i;
        private int j;
        private int elements;
        public RoundArray()
        {
            numbers = new T[4];
        }
        public void Add(T num)
        {
            if (elements >= numbers.Length)
            {
                throw new OverflowException();
            }

            elements++;
            if (i == numbers.Length)
            {
                i = 0;
            }

            numbers[i] = num;
            i++;
        }

        public void Remove()
        {
            if (elements == 0)
            {
                throw new InvalidOperationException();
            }

            elements--;
            if (j == numbers.Length)
            {
                j = 0;
            }

            numbers[j] = default(T);
            j++;
        }
    }

    public class FiLo
    {
        private int[] numbers;
        private int i;

        public FiLo()
        {
            numbers = new int[4];
        }

        public void Add(int num)
        {
            numbers[i] = num;
            i++;
        }

        public void Remove()
        {
            numbers[i - 1] = 0;
            i--;
        }
    }
    public class FiFo
    {
        private int[] numbers;
        private int i;
        private int j;
        public FiFo()
        {
            numbers = new int[4];
        }
        public void Add(int num)
        {
            if (i < numbers.Length)
            {
                numbers[i] = num;
                i++;
            }
        }

        public void Remove()
        {
            numbers[j] = 0;
            j++;
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            //FiLo filo = new FiLo();
            //filo.Add(1);
            //filo.Add(2);
            //filo.Add(3);
            //filo.Remove();
            //filo.Remove();
            //filo.Remove();
            //filo.Add(4);

            //FiLo filo = new FiLo();
            //filo.Add(1);
            //filo.Add(2);
            //filo.Add(3);
            //filo.Remove();
            //filo.Remove();
            //filo.Remove();
            //filo.Add(4);
            //filo.Add(5);
            //filo.Add(6);
            //filo.Remove();

            //RoundArray<int> round = new RoundArray<int>();
            //round.Add(1);
            //round.Add(2);
            //round.Add(3);
            //round.Add(4);
            //round.Remove();
            //round.Add(5);
            //round.Remove();
            //round.Add(6);
            //round.Add(7);



        }
    }
}
