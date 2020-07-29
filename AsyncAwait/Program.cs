using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncAwait
{
   class Program  
{  
    static async Task Main(string[] args)
        {
            var stopWatch = Stopwatch.StartNew();
            var Task1 = Add();
            var Task2 = Sub();
           
            await Task.WhenAll(Task1, Task2 );
            Console.WriteLine("Total time: " + stopWatch.Elapsed.Seconds + "Seconds");
            Console.ReadLine();

        }
        public static async Task Add()
        {
            
            Console.WriteLine("addition started at " + DateTime.Now);
            await Task.Delay(5000);
            int a = 5; int b = 6;
            int c = a + b;          
            Console.WriteLine("addition completed: {0} {1}" , c, DateTime.Now);
        }

        public static async Task Sub()
        {
            Console.WriteLine("subtraction started at " + DateTime.Now);          
            await Task.Delay(1000);
            int a = 6; int b = 5;
            int c = a - b;
            Console.WriteLine("subtraction completed: {0} {1}" ,c, DateTime.Now);
        }
}  
}
