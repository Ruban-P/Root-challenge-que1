using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rolled_number
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int NumberOfRounds = Convert.ToInt32(Console.ReadLine());
             int[] array=new int[NumberOfRounds];
            for (int i = 0; i < NumberOfRounds; i++)
            {
                string round_i = Console.ReadLine();
                array[i]=reverse(concat(round_i));
            }
            average(array);
        }

        public static int concat(string input)
        {
            string combine = "";
            string[] w = input.Split();
            for (int i = 0; i < w.Length; i++)
            {
                combine += w[i];
            }
            int value = Convert.ToInt32(combine);
            return value;
        }

        public static int reverse(int value)
        {
            int reverse_value = 0;
            while (value > 0)
            {
                int x = value % 10;
                reverse_value = (10 * reverse_value)+x;
                value = value / 10;
            }
            return reverse_value;
        }

        public static void average(int[] value)
        {
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                sum += value[i];
                double avg = sum / (double)(i + 1); 
                double average=Math.Round(avg,1);
                Console.WriteLine(value[i]+" "+average);
            }
        }
    }
}
