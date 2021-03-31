using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void TestException(int count)
        {
            if (count < 0) 
            {
                throw new Exception("count can not be less 0");
            }
            int[] nums = new int[5];
            try
            {
                Console.WriteLine("До исключения");
                for (int i = 0; i < nums.Length; ++i)
                {
                    nums[i] = 10 + i;
                }

                double[] mas = null;
                Array.Copy(nums, mas, nums.Length);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("\nArgumentNullException in TestException " + ex.Message);
            }

            var n = 0;
            var result = 100 / n;

            for (int i = 0; i < count; ++i)
            {
                Console.Write($"{nums[i]}");
            }        
        }

        static void Main(string[] args)
        {
            try
            {  
                try
                {
                    TestException(-5);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("\nInner Exception " + ex.Message);
                }
                TestException(5);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("\nDivideByZeroException " + ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("\nIndexOutOfRangeException " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("\nException " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nВыполняется всегда");
            }

           Console.WriteLine("\nПосле исключения");
        }
    }
}
