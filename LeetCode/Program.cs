using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Easy easy = new Easy();
            //easy.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            // easy.GetConcatenation(new int[] { 2, 7, 11, 15 }); 
            //PopulateDvD();
            // PopulateDataUsingLoop();


            // var maxConsecutiveOnes =  Array101.findMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });

            ;
            //Console.WriteLine(Array101.FindNumbers(new int[] { 555, 901, 482, 1771 }));


            //var res = Array101.SortedSquares(new int[] { -
            //7, -3, 2, 3, 11 });

            // var res = Array101.DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 });

            //Array101.merge(new int[] { 1, 2, 3, 0, 0, 0 },3,new int[] { 2, 5, 6 },3);

            //DeleteFirstElement(); 



            //RemoveLastElement();

            //RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);

            //  RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });







            // int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // RemoveElementAtIndex(ref numbers, 4);


            //  Console.WriteLine($"Array : {string.Join(" ", numbers)}");

            //CountDown(10);
            //Factorial(5);
            //var powerResult = Power(5, 3);

            // int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //var index = BinarySearch(sortedArray, 4);

            //FilterDuplicateValue(); 

            //ValueCount();


            //string[] input = { "flower", "flight", "fly", "flow" };
            //string result = LongestCommonPrefix(input);
            //Console.WriteLine("Longest Common Prefix is- " + result); // Output: "fl"


            //Console.WriteLine(validParentheses("()")); // true
            //Console.WriteLine(validParentheses("()[]{}")); // true
            //Console.WriteLine(validParentheses("(]")); // false
            //Console.WriteLine(validParentheses("([)]")); // false
            //Console.WriteLine(validParentheses("{[]}")); // true

            //Console.WriteLine(validParentheses("(([]){})"));
            //var result = LengthOfLastWord("   fly me   to   the moon  ");

            //var result2 = PlusOne(new int[] { 9,9,9});

            //var i = MySqrt(8);
            SingleNumber(new int[] { 4, 1, 2, 1, 2 });

        }




        //-----------------------------------------------------------------------------
        // // 58. Length of Last Word
        // Link: https://leetcode.com/problems/length-of-last-word/description/
        //-----------------------------------------------------------------------------

        public static int LengthOfLastWord(string s)
        {
            var words =  s.Split(' ');

            for (int i = words.Length-1; i >= 0; i--)
            {

                if (!string.IsNullOrEmpty(words[i]))
                {
                    return words[i].Length;
                }
            }

            return 0;

        }


        //-----------------------------------------------------------------------------
        // 66. Plus One
        // Link: https://leetcode.com/problems/plus-one/description/
        //-----------------------------------------------------------------------------

        public static int[] PlusOne(int[] digits)
        {
            List<int> results = new List<int>();
            int carry = 1;
            int sum = 0;

            for (int i = digits.Length-1; i >=0; i--)
            {
                sum = digits[i] + carry;
                carry = sum ==10 ? 1 : 0;
                results.Insert(0, sum % 10);
            }

            if (carry >0)
            {
                results.Insert(0, carry);
            }  

            return results.ToArray();

        }




        //-----------------------------------------------------------------------------
        // 69. Sqrt(x)
        // Link:     https://leetcode.com/problems/sqrtx/
        //-----------------------------------------------------------------------------


        static int MySqrt(int x)
        {

            if (x ==0)
            {
                return 0;
            }
            int left = 0;
            int right = x;
            while (left <= right)
            {
                //calculate mid
                int mid = left + (right - left)/2;
                //check if mid* mid is close to x

                if (mid<= x/mid &&  mid+1 > x/(mid+1))
                {
                    return mid;
                    
                }

                //Adjust Search Range
                if (mid> x/mid)
                {
                    right = mid - 1;
                }
                else 
                {
                    left = mid + 1;
                }

            }

            return 0;
        
        }
        static int XMySqrt(int x)
        {
            if (x == 0)
                return 0;

            int left = 1;
            int right = x;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if mid*mid is close to x
                if (mid <= x / mid && (mid + 1) > x / (mid + 1))
                    return mid;

                // Adjust the search range
                if (mid > x / mid)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return 0; // This line should not be reached for non-negative integers
        }

        /// <summary>
        ///   https://leetcode.com/problems/single-number/
        /// https://leetcode.com/problems/single-number/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumber(int[] nums)
        {
            var a = 0;
            foreach (var num in nums)
                a ^= num;

            return a;
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string pre = string.Empty;

            if (strs.Length ==0)
            {

                return pre;
            }

            Array.Sort(strs);

            for (int i = 0; i < strs[0].Length; i++)
            {
                  char c = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != c)
                    {

                        return pre;
                    }

                  
                }

                pre += c;

            }


            return pre;
        }


        public static bool validParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            int numberOfElement = s.Length;
            if (numberOfElement %2 !=0)
            {
                return false;
            }

            for (int i =0; i < s.Length;i++) 
            {
                char bracket = s[i];


                if ((i %2 == 0) && s[i] =='(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0) { return false; }

                    char openBracket = stack.Pop();

                    if ((i % 2 == 1) && s[i] == '(' || s[i] == '{' || s[i] == '[')
                    {
                        return false;
                    }

                    if ( (bracket ==')' && openBracket !='(') ||
                         (bracket == '}' && openBracket != '{') ||
                          (bracket == ']' && openBracket != '['))
                    {
                        return false;
                    }



                }
            }

            return stack.Count == 0;

        }


        static void FilterDuplicateValue()
        {
            List<string> fruitNames = new List<string>
            {
                "Apple", "Banana", "Orange", "Apple", "Grapes", "Banana", "Kiwi", "Orange"
            };

            Dictionary<string, string> fruitKeyValuePair = new Dictionary<string, string>();


            //foreach (var fruit in fruitNames)
            //{
            //    if (!fruitKeyValuePair.ContainsKey(fruit))
            //    {
            //        fruitKeyValuePair.Add(fruit, fruit);
            //    }
            //}


            //Console.WriteLine($"Fruits : {string.Join(" ", fruitKeyValuePair.Keys)}");


            fruitNames.Distinct()
                .ToList()
                .ForEach(x => Console.WriteLine(x));


        }


        static void ValueCount()
        {
            List<string> fruitNames = new List<string>
            {
                "Apple", "Banana", "Orange", "Apple", "Grapes", "Banana", "Kiwi", "Orange"
            };

            Dictionary<string, int> fruitKeyValuePair = new Dictionary<string, int>();


            //fruitNames.ForEach(x =>
            //{
            //    if (fruitKeyValuePair.ContainsKey(x))
            //    {
            //        fruitKeyValuePair[x] = fruitKeyValuePair[x] + 1;
            //    }
            //    else
            //    {
            //        fruitKeyValuePair.Add(x, 1);
            //    }
            //});    

            fruitNames.GroupBy(x => x)
                .Select(x => new { Fruit = x.Key, Count = x.Count() })
                .ToList()
                .ForEach(x => Console.WriteLine($"Fruit : {x.Fruit} , Count : {x.Count}"));




        }

        static void CountDown(int num)
        {
            if (num ==0)
            {
                Console.WriteLine("Dowe");
                return;
            }

            Console.WriteLine(num);
            CountDown(num - 1);
        }

        static int Factorial(int num)
        {
            if (num ==1)
            {
                return 1;

            }
            return num * Factorial(num - 1);
        }



        static int Power(int num, int pow)
        {
           if (pow == 0)
            {
                return 1;
            }

            return num * Power(num, pow - 1);
        }
      

        static int BinarySearch(int[] sortedArray  , int target)
        {
            int index = -1;

            int left = 0; 
            int right = sortedArray.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (sortedArray[mid] == target)
                {
                       index = mid;
                       return mid;
                }
                     

                if (sortedArray[mid] < target)
                     left = mid + 1;
                else
                {
                    right= mid - 1;
                }
            }

            return index;




        }

        private static int RemoveDuplicates(int[] nums)
        {

            if (nums.Length == 0)
            {
                return 0; // If the array is empty, there are no duplicates
            }
            int uniqueCount = 1;

            for (int i = 1; i < nums.Length ; i++)
            {
                if (nums[i] != nums[i -1])
                {
                    nums[uniqueCount] = nums[i];
                    uniqueCount++;
                }

            }

            return uniqueCount;
        }

        private static int RemoveElement(int[] nums, int value)
        {

            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != value)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            return index;
        }

        private static int[] RemoveElementAtIndex(ref int[] numbers, int indexAt)
        {
     

            indexAt = 5;
            for (int i = indexAt; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }

            Array.Resize(ref numbers, numbers.Length - 1);
            return numbers;
        }

        private static void RemoveLastElement()
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            Array.Resize(ref numbers, numbers.Length - 1);


            Console.WriteLine($"Array : {string.Join(" ", numbers)}");
        }

        private static void DeleteFirstElement()
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine($"length : {numbers.Length}");

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }

            Array.Resize(ref numbers, numbers.Length - 1);


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"index {i} : value {numbers[i]}");
            }
        }

        private static void PopulateDataUsingLoop()
        {
       

            int[] squareNumbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                squareNumbers[i] = (i + 1) * (i + 1);

            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine( $"{i+1} : {squareNumbers[i]}");
            }
        }

        private static void PopulateDvD()
        {
            DVD[] dvds = new DVD[15];

            DVD avengersDVD = new DVD("The Avengers", 2012, "Joss Whedon");
            DVD incrediblesDVD = new DVD("The Incredibles", 2004, "Brad Bird");
            DVD findingDoryDVD = new DVD("Finding Dory", 2016, "Andrew Stanton");
            DVD lionKingDVD = new DVD("The Lion King", 2019, "Jon Favreau");

            dvds[7] = avengersDVD;
            dvds[3] = incrediblesDVD;
            dvds[9] = findingDoryDVD;
            dvds[2] = lionKingDVD;


            Console.WriteLine(dvds[7]);
            Console.WriteLine(dvds[3]);
            Console.WriteLine(dvds[10]);
        }
       
    }
}
