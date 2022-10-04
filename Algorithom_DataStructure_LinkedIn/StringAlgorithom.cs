using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithom_DataStructure_LinkedIn
{
    public class StringAlgorithom
    {
        //IsUppercase
        //IsLowercase
        //isPasswordComplex
        public static Boolean IsUppercase(string input)
        {
            return input.All(char.IsUpper);
        }

        public static bool IsLowercase(string input)
        {
            return input.All(char.IsLower);
        }


        public static bool IsPasswordComplex(string input)
        {
            return input.Any(char.IsLower) && input.Any(char.IsUpper) && input.Any(char.IsNumber);
        }


        public static string NormalizeString(string input)
        {
            return input.ToLower().Trim().Replace(",", "");
        }


        public static string Reverse(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder stringBuilder = new StringBuilder(input.Length);


            for (int i = input.Length -1; i >=0; i--)
            {
                stringBuilder.Append(input[i]);
            }

            return stringBuilder.ToString();

        }

        public static string Reverse_2(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);

        }


        public static string ReverseEachWord(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;

            }

            string[] arr = input.Split(' ');
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                stringBuilder.Append(Reverse(arr[i]));

                if (i != arr.Length -1)
                {
                    stringBuilder.Append(" ");
                }

            }

            return stringBuilder.ToString();


        }


    }
}
