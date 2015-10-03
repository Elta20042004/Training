using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candies
{
    class Program
    {
        private static int[] _numbers;
        private static int[] _candyArray;

        static void Process()
        {
            int index = 0;
            while (index < _numbers.Length)
            {
                if (index == 0)
                {
                    _candyArray[index]++;
                    index++;
                }
                else if (_numbers[index] < _numbers[index - 1] && _candyArray[index - 1] == 1)
                {
                    index--;
                }
                else if (_numbers[index] < _numbers[index - 1])
                {
                    if (_candyArray[index] + 1 >= _candyArray[index - 1])
                    {
                        index--;
                    }
                    else
                    {
                        _candyArray[index]++;
                        index++;
                    }
                }
                else if (_numbers[index] > _numbers[index - 1])
                {
                    _candyArray[index] = Math.Max(_candyArray[index - 1] + 1, _candyArray[index] + 1);
                    index++;
                }
                else if (_numbers[index] == _numbers[index - 1])
                {
                    _candyArray[index]++;
                    index++;
                }
            }

            Console.WriteLine(_candyArray.Sum(t => t));
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            _numbers = new int[t];
            _candyArray = new int[t];
            for (int i = 0; i < t; i++)
            {
                int rating = int.Parse(Console.ReadLine());
                _numbers[i] = rating;
            }

            Process();
        }
    }
}
