namespace ArrayProblemSolving_01
{
    internal class Program
    {
        public static int? findSecondSmallestNumber_2(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return null;
            }

            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    return arr[i + 1];
                }

            }


            return null;
        }


        public static int? findSecondSmallestNumber(int[] arr)
        {
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];

                if (current < smallest)
                {
                    secondSmallest = smallest;
                    smallest = current;

                }
                else if (current < secondSmallest && current != smallest)
                {
                    secondSmallest = current;
                }
            }





            return secondSmallest == int.MaxValue ? null : secondSmallest;
        }
        static void Main(string[] args)
        {
            // SecondSmallestNumber();
            // PrintTriangle(new int[] { 1, 2, 3, 4 });

            //var arr = rotateRight(new int[] { 1, 2, 3, 4, 5 });

            // Array.ForEach(arr, Console.WriteLine);

            //var arr2 = moveZeroToTheEnd(new int[] { 0, 1, 0, 8, 9, 0, 4 });

            //int[] arr3 = new int[] { 1, 2, 3, 4, 5 };
            // ReverseArray(arr3);
            //Array.ForEach(arr3, Console.WriteLine);

          //  int[] arr3 = new int[] { 1, 2, 3, 4, 5 };

          // var RunningSums = RunningSum(arr3);
                                                           
          var accounts = new int[][]{ new int[]{1, 5 }, new int[]{ 7, 3 }, new int[]{ 3, 5 } };


         var maxWealth = MaximumWealth(accounts);

        }

        public static void ReverseArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        private static void PrintTriangle(int[] arr)
        {
            for (int row = 0; row < arr.Length; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(arr[col]);
                }
                Console.WriteLine();

            }
        }


        private static int[] moveZeroToTheEnd(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count] = arr[i];
                    count++;
                }
            }

            while (count < arr.Length)
            {
                arr[count] = 0;
                count++;

            }

            return arr;
        }
        private static int[] rotateRight(int[] arr)
        {
            int[] result = new int[arr.Length];



            for (int i = 0; i < arr.Length; i++)
            {
                result[(i + 1) % arr.Length] = arr[i];
            }

            return result;
        }

        private static void SecondSmallestNumber()
        {
            int[] arr = new int[] { 5, 8, 3, 2, 6 };
            int[] arr2 = new int[] { 3, 8, 5, 2, 6 };

            int[] arr3 = new int[] { 6, 8, 5, 2, 3 };

            int[] arr4 = new int[] { 5, 8, 3, 2, 6 };

            int[] arr5 = new int[] { 3, 3, 3, 3, 3, 3 };

            int[] arr6 = new int[] { 3, 3, 3, 3, 2, 3 };

            int[] arr7 = new int[] { 5, 8, 3, 2, 6 };
            int[] arr9 = new int[] { 3, 3, 3, 3, 4 };
            int[] arr10 = new int[] { };
            int[] arr11 = new int[] { 1 };

            Console.WriteLine("arr :" + findSecondSmallestNumber(arr));
            Console.WriteLine("arr2 :" + findSecondSmallestNumber(arr2));
            Console.WriteLine("arr3 :" + findSecondSmallestNumber(arr3));
            Console.WriteLine("arr4 :" + findSecondSmallestNumber(arr4));
            Console.WriteLine("arr5 :" + findSecondSmallestNumber(arr5));
            Console.WriteLine("arr6 :" + findSecondSmallestNumber(arr6));
            Console.WriteLine("arr7 :" + findSecondSmallestNumber(arr7));
            Console.WriteLine("arr11 :" + findSecondSmallestNumber(arr11));
            Console.WriteLine("arr9 :" + findSecondSmallestNumber(arr9));
            Console.WriteLine("arr10 :" + findSecondSmallestNumber(arr10));
            Console.WriteLine("arr11 :" + findSecondSmallestNumber(arr11));
        }


        //1480. Running Sum of 1d Array
        public static int[] RunningSum(int[] nums)
        {

            int[] results = new int[nums.Length];

            results[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                results[i] = nums[i] + results[i - 1];


            }

            return results;


        }

        public static int[] RunningSum_V2(int[] nums)
        {



         

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];


            }


            return nums;


        }


        //https://leetcode.com/problems/richest-customer-wealth/
        //1672. Richest Customer Wealth
        public  static int MaximumWealth(int[][] accounts)
        {
            int maxWealthSoFar = 0;

            foreach (var customer in accounts)
            {
                int currentCustomerWealth = 0;
                foreach (var bank in customer)
                {

                    currentCustomerWealth += bank;
                }

                maxWealthSoFar = Math.Max(maxWealthSoFar, currentCustomerWealth);


            }
            return maxWealthSoFar;

        }


        public static int MaximumWealth_V2(int[][] accounts)
        {
            int maxWealthSoFar = 0;

            foreach (var customer in accounts)
            {

                maxWealthSoFar = customer.Sum() > maxWealthSoFar ? customer.Sum() : maxWealthSoFar;

            }
            return maxWealthSoFar;

        }
    }
}