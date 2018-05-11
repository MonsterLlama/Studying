using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLlama.Studying.LeetCode
{
    public static partial class LeetCode
    {

        // https://leetcode.com/problems/two-sum/description/
        //
        //  Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //
        //  You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //
        public static (int indexA, int indexB) TwoSum(int[] A, int target)
        {
            var result = (-1, -1);

            if (A == null || A.Length < 2)
            {
                return result;  // Should probably throw an Exception here ... ^ ^
            }

            // Dictionary's Keys will represent the values in the passsed in Array.
            // Its Values will represent the Array index where that value resides.
            //
            // Add value/index for the first element of the Array.
            var dict = new Dictionary<int, int>()
            {
                [A[0]] = 0
            };

            // Iterate over the rest of the passed in Array and check whether we
            // have a match for the target when summing the values from two indexes.
            for (int index = 0; index < A.Length; index++)
            {
                var match = target - A[index];

                // Do we have a match for the current index?
                if (dict.ContainsKey(match))
                {
                    return (indexA: dict[match], indexB: index);
                }
                else
                {
                    dict[A[index]] = index;
                }
            }


            return result;
        }

    }
}
