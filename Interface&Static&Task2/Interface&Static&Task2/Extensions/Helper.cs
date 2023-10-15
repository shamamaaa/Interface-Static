using System;
using System.Text;

namespace Interface_Static_Task2.Extensions
{
	public static class Helper
	{
        public static bool IsOdd(this int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HasDigit(this string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPassword(this string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            bool hasupper = false;
            bool haslower = false;
            bool hasdigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasupper = true;
                else if (char.IsLower(c))
                    haslower = true;
                else if (char.IsDigit(c))
                    hasdigit = true;
            }

            if (hasupper && haslower && hasdigit)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static string Capitalize(this string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input.Trim().ToLower());
            sb[0] = char.ToUpper(input[0]);
            return sb.ToString();
        }

    }
}

