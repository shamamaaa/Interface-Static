using System;
using System.Text;

namespace Interface_Static_Task3.Extension
{
	internal static class Helper
	{
        public static string Capitalize(this string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str.Trim().ToLower());
            sb[0] = char.ToUpper(str[0]);
            return sb.ToString();
        }

        public static bool CheckName(this string name)
        {
            name = name.Trim().ToLower();

            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    return false;
                }

            }
            if (name.Length >= 3 && name.Length <= 25)
            {
                return true;
            }
            else return false;
        }

        public static bool CheckGroupName(this string name)
        {
            name = name.Trim().ToUpper();
            if (name.Length >= 3 && name.Length <= 25)
            {
                return true;
            }
            else return false;

        }
    }
}

