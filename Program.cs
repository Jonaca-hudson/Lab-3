using System;

namespace GC_class916
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Learn your squares and cubes!");

                Console.Write("Enter a number: ");
                string input1 = Console.ReadLine();
                int.Parse(input1);

                int num = int.Parse(input1);

                
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine("Number  Squared  Cubed");
                    Console.WriteLine("======= ======= =======");
                    Console.WriteLine(value: i +"\t"+i*i+"\t"+i*i*i);
                    
                   
                }
               
                
                Console.WriteLine("Continue? Y or N");
                string answer;

                answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }
        }
    }
}
