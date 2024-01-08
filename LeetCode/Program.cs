using System;
using System.Collections.Generic;
using System.Globalization;

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
