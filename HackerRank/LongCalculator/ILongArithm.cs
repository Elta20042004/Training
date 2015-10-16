using System.Collections.Generic;

namespace LongCalculator
{
    public interface ILongArithm
    {
        /// <summary>
        /// Multiplication by one digit.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="integer"></param>
        /// <returns></returns>
        List<int> MultiplicationByOneInteger(List<int> one, int integer);

        /// <summary>
        /// Multiplication long numbers.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        List<int> Multiplication(List<int> one, List<int> two);

        /// <summary>
        /// Subtraction long numbers.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        List<int> Subtraction(List<int> one, List<int> two);

        /// <summary>
        /// Compare two long numbers
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        int Compare(List<int> one, List<int> two);

        /// <summary>
        /// Sum two long numbers
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        List<int> Summ(List<int> one, List<int> two);

        /// <summary>
        /// Convert string to long number
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        List<int> ConvertStringToLongNumber(string text);
    }
}