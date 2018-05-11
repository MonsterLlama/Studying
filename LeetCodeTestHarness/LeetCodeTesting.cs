using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Diagnostics.Debug;


namespace MonsterLlama.Studying.LeetCode
{
    public class LeetCodeTesting
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 5, 7, 8, 9 };

            var result = LeetCode.TwoSum(array1, 13);
                result = LeetCode.TwoSum(array1, 16);
                result = LeetCode.TwoSum(array1, 10);

            WriteLine($"*** (Debug Info: {array1[result.indexA]} + {array1[result.indexB]} = 10) ***");

                result = LeetCode.TwoSum(array1, 20);
            
        }
    }
}
