using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Array101
    {

        /*485 Max Consecutive Ones*/
        public static int findMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int count = 0;

            for (int i = 0; i < nums.Length;i++)
            {
                if (nums[i] ==1)
                {  

                    count++;

                }
                else
                { 
                    max = Math.Max(max,count);
                    count=0;
                  
                }

            }

            max = Math.Max(max, count);
            return max;




        }
        /*
            An Array is a collection of items. The items could be integers, strings, DVDs, games, books—anything really.
            The items are stored in neighboring (contiguous) memory locations. Because they're stored together, 
            checking through the entire collection of items is straightforward.

         */



        public static int FindNumbers(int[] nums)
        {
            int evens = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int digit = 0;
                int number = nums[i];

                while (number !=0)
                {
                    number /= 10;
                    ++digit;

                }
                if (digit % 2==0)
                {
                    evens++;
                }

             

            }   
            return evens;
        }



        public static int[] SortedSquares(int[] nums)
        {
            int[] res = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                res[i]= nums[i] * nums[i];

            }

            Array.Sort(res);
            return res;

        }

    }

    public class DVD
    {
        public String name;
        public int releaseYear;
        public String director;

        public DVD(string name, int releaseYear, string director)
        {
            this.name = name;
            this.releaseYear = releaseYear;
            this.director = director;
        }

        public override string ToString()
        {
            return this.name + ", directed by " + this.director + ", released in " + this.releaseYear;
        }
    }


}
