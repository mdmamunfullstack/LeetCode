using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithom_DataStructure_LinkedIn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(StringAlgorithom.IsUppercase("hello"));
            //Console.WriteLine(StringAlgorithom.IsUppercase("HELLO"));

            //Console.WriteLine(StringAlgorithom.IsLowercase("hello"));
            //Console.WriteLine(StringAlgorithom.IsLowercase("HELLO"));

            //Console.WriteLine(StringAlgorithom.IsPasswordComplex("Hell0"));
            //Console.WriteLine(StringAlgorithom.IsPasswordComplex("Hello"));
            //Console.WriteLine(StringAlgorithom.IsPasswordComplex("HellO"));
            //Console.WriteLine(StringAlgorithom.IsPasswordComplex("HeLlo"));
            //Console.WriteLine(StringAlgorithom.IsPasswordComplex("hello"));
            //Console.WriteLine(StringAlgorithom.IsPasswordComplex(" "));

            //Console.WriteLine(StringAlgorithom.NormalizeString(" Hi Mamun, How are you?       "));


            //Console.WriteLine(StringAlgorithom.Reverse("Hell0. "));
            //Console.WriteLine(StringAlgorithom.Reverse("Hello123 "));
            //Console.WriteLine(StringAlgorithom.Reverse(""));
            //Console.WriteLine(StringAlgorithom.Reverse(null));



            //Console.WriteLine(StringAlgorithom.ReverseEachWord("Taylor is a great worker"));
            //Console.WriteLine(StringAlgorithom.ReverseEachWord(null));
            //Console.WriteLine(StringAlgorithom.ReverseEachWord("racer racecar madam"));
            //Console.WriteLine(StringAlgorithom.ReverseEachWord("what can I do today"));
            //Console.WriteLine(StringAlgorithom.ReverseEachWord(" "));


            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(ArrayAlgorithom.BinarySearch(arr, 100));
            Console.ReadKey();
        }
    }
}
