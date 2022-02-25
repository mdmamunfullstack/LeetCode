using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public  class Easy
    {
        //https://leetcode.com/problems/two-sum/ 
         
        #region 1. Two Sum
        public int[] TwoSum(int[] nums, int target)
        {
            int[] arr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        arr[0] = i;
                        arr[1] = j;
                        break;
                    }
                }
            }
            return arr;
        }


        public int[] TwoSum_2(int[] nums, int target)
        {
            var arrayLenght = nums.Length;

            for (int i = 0; i < arrayLenght; i++)
            {
                for (int j = i + 1; j < arrayLenght; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }

                }


            }
            return Array.Empty<int>();
        }

        public int[] TwoSum_3(int[] nums, int target)
        {
            var arrayLenght = nums.Length;

            for (int i = 0; i < arrayLenght; i++)
            {
                for (int j = i + 1; j < arrayLenght; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }

                }


            }
            return Array.Empty<int>();
        }
        #endregion

        #region ExerciseForPractice
        static int ExAddDigits(int num)
        {
            /*
              https://leetcode.com/problems/add-digits/
               258. Add Digits
            */
            string str = num.ToString();
            if (str.Length < 2)
            {
                return int.Parse(str);
            }
            else
            {
                int temp = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    temp += int.Parse(str[i].ToString());
                }

                return AddDigits(temp);
            }
        }
        static int ExSumOfDigits(int num)
        {
            int temp, r, sum = 0;
            temp = num;

            while (temp != 0)
            {
                r = temp % 10;
                sum += r;
                temp = temp / 10;

            }
            return sum;


        }
        static int ExReverseDigits(int num)
        {
            int temp, r, reverseDisit = 0;
            temp = num;

            while (temp != 0)
            {
                r = temp % 10;
                temp = temp / 10;
                reverseDisit = (reverseDisit * 10) + r;
            }

            return reverseDisit;
        }
        static bool ExIsPalindrome(int x)
        {
            /*
                https://leetcode.com/problems/palindrome-number/
                9. Palindrome Number
             */


            int temp, r, reverseDisit = 0;
            temp = x;

            while (temp != 0)
            {
                r = temp % 10;
                temp = temp / 10;
                reverseDisit = (reverseDisit * 10) + r;
            }

            if (reverseDisit == x)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        public static int[] ExBuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }
            return ans;
        }


        public static int ExSearch(int[] nums, int target)
        {
            /*
            int low = 0, mid = 0, high = nums.Length - 1;
            while (low < high)
            {
                mid = low + (high - low) / 2;//Anti-overflow
                                             //Do not judge equality, make low, mid, and high keep approaching the target index
                if (nums[mid] < target) low = mid + 1;
                else high = mid;
            }
            //If it exists, return any of the three, otherwise return -1
            return nums[low] == target ? low : -1;
            */

            return Array.IndexOf(nums, target);
        }


        public static int ExBinarySearch(int[] nums, int target)
        {

            int low = 0, mid = 0, high = nums.Length - 1;
            while (low < high)
            {
                mid = low + (high - low) / 2;//Anti-overflow
                                             //Do not judge equality, make low, mid, and high keep approaching the target index
                if (nums[mid] < target) low = mid + 1;
                else high = mid;
            }

            //If it exists, return any of the three, otherwise return -1
            return nums[low] == target ? low : -1;


            return Array.IndexOf(nums, target);
        }

        public static int ExFinalValueAfterOperations(string[] operations)
        {
            int x = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i].Contains("-"))
                {
                    x--;
                }
                else
                {
                    x++;
                }
            }
            return x;

        }


        public static int ExMostWordsFound(string[] sentences)
        {
            int[] wordsFoundCounts = new int[sentences.Length];
            for (int i = 0; i < sentences.Length; i++)
            {
                wordsFoundCounts[i] = sentences[i].Split(" ").Length;
            }

            return wordsFoundCounts.Max();
        }


        public static int[] ExShuffle(int[] nums, int n)
        {
            int[] result = new int[2 * n];

            for (int i = 0; i < n; i++)
            {
                result[i * 2] = nums[i];
            }

            for (int j = 1; j < n + 1; j++)
            {
                result[(j * 2) - 1] = nums[n + j - 1];
            }
            return result;

        }
        public static int[] ExGetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length * 2; i++)
            {

                ans[i] = nums[i % nums.Length];
            }
            return ans;
        }


        public static int[] ExRunningSum(int[] nums)
        {
            int[] ans = new int[nums.Length];
            ans[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                ans[i] = ans[i - 1] + nums[i];
            }

            return ans;
        }

        static int[] ExGenerateRandomArray(int size)
        {
            var rnd = new Random();
            int[] result = new int[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = rnd.Next(0, 100);
            }

            return result;
        }

        #endregion
    }
}
