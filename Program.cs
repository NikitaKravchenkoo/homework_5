using System;
using homeworkhelper;

namespace homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(numericalhelper.CalculateFormmula(10,5));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
