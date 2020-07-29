using System;

namespace Delegates
{
    class Program
    {
        delegate int DelegateTest(int n);
        static int num = 10;
      
      public static int AddNum(int p) {
         num += p;
         return num;
      }
      public static int MultNum(int q) {
         num *= q;
         return num;
      }
      public static int getNum() {
         return num;
      }
        static void Main(string[] args)
        {
             DelegateTest n1 = new DelegateTest(AddNum);
             DelegateTest n2 = new DelegateTest(MultNum);
         
         //calling the methods using the delegate objects
         n1(25);
         Console.WriteLine("Value : {0}", getNum());
         n2(5);
         Console.WriteLine("Value : {0}", getNum());
         Console.ReadKey();
        }
    }
}
