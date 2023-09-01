using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text;

namespace dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            ////create arr with 5 dice i there
            //int[] PlayerRandomNum = new int[5];


            // make random nr for  dices
            Random random = new Random();

            int sides = 6;
            int rolls = 10;
            int[] results = new int[sides];

            for( int i = 0; i < rolls; i++)
            {
                int roll = random.Next(1, sides + 1);

                results[roll - 1]++;
                Console.WriteLine("Roll{0}:{1}", i + 1, roll);
            }

            Console.WriteLine("\n results:");
            for ( int i = 0;i < sides; i++)
            {
                Console.WriteLine("{0}:{1}",i+1,results[i]);
            }



            
        }
    }
}