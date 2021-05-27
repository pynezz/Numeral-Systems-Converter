using System;
using System.Text;

namespace Numeral_Systems_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to convert to binary (base 2):");
            string num = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(ToBase2(num));
            Console.WriteLine(" ");
            
        }

        static string FromBase2(string num)
        {
            string ret = "";
            for (int i = 0; i < num.Length; i++)
            {
                int j = num[i];
                ret += j * 2 * i;
            }
            return ret;
        }

        static string ToBase2(string num)
        {
            ErrorCheck(num);
            //string result = "00000000";
            string result = "";
            int temp = int.Parse(num);
            int i = 1;
            while (temp > 0)
            {
                //result.Replace(result[result.Length - i], char.Parse(IsEven(temp) ? "0" : "1"));

                result += IsEven(temp) ? "0" : "1";
                temp /= 2; // int gets floored
                i++;
                
            }
            return result;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static ArgumentException ErrorCheck(string num)
        {
            bool b = int.TryParse(num, out int cNum);
            if (!b)
            {
                throw new ArgumentException("Cannot parse this int as string to int. Does it contain only 0-9?", nameof(num));
            }
            else if (num == null)
            {
                throw new ArgumentException("Cannon be null...", nameof(num));
            }
            return new ArgumentException("An error occured");
        }
    }
}
