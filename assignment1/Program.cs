using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nType a string of numbers and seprate them by '+' then press Enter. ");
            string strInput = Console.ReadLine();
            int sum=0;

            int[] arrInput = Array.ConvertAll(strInput.Split('+'), int.Parse);
            foreach(int x in arrInput)
            {
                sum += x;
            }
            Console.WriteLine(sum);
           
        }
    }
}
