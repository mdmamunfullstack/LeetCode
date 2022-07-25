using System;

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
            Console.WriteLine(Array101.FindNumbers(new int[] { 555, 901, 482, 1771 }));


           var res = Array101.SortedSquares(new int[] { -7, -3, 2, 3, 11 });

            Console.WriteLine();

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
