using System;
using System.Text.RegularExpressions;

class Program
{
    private static int SushiLineLength(string sushi)
    {
        int[] buff = new int[sushi.Length];
        int max = 1;
        int bi = 0;
        buff[0] = 1;
        for (int i = 1; i < sushi.Length; i++)
        {
            if (sushi[i] == sushi[i - 1] & i < sushi.Length - 1)
            {
                ++buff[bi];
            }
            else if (sushi[i] == sushi[i - 1] & i == sushi.Length - 1)
            {
                ++buff[bi];
                max = Math.Max(max, Math.Min(buff[bi], buff[bi - 1]));
            }
            else
            {
                if (bi > 0)
                {
                    max = Math.Max(max, Math.Min(buff[bi], buff[bi - 1]));
                }
                ++bi;
                ++buff[bi];
            }
        }
        return max * 2;
    }

    public static void Main(string[] args)
    {
        int l = Convert.ToInt32(Console.ReadLine());
        string input = Regex.Replace(Console.ReadLine(), @"\s+", "");
        Console.WriteLine("{0}", SushiLineLength(input.Substring(0, l)));
    }
}