using System.Collections.Generic;

namespace LongCalculator
{
    class LongArithmMock : ILongArithm
    {
        public List<int> MultiplicationByOneInteger(List<int> one, int integer)
        {
            return new List<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
        }

        public List<int> Multiplication(List<int> one, List<int> two)
        {
            return new List<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
        }

        public List<int> Subtraction(List<int> one, List<int> two)
        {
            return new List<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
        }

        public int Compare(List<int> one, List<int> two)
        {
            return 1;
        }

        public List<int> Summ(List<int> one, List<int> two)
        {
            return new List<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
        }

        public List<int> ConvertStringToLongNumber(string text)
        {
            return new List<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
        }
    }
}