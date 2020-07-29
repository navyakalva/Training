using System;

namespace Events
{
    
        public delegate int Delegate(int a, int b);
        class EventExample
        {
            event Delegate myEvent1;
            event Delegate myEvent2;
            public EventExample()
            {
                this.myEvent1 += new Delegate(this.Add);
                this.myEvent2 += new Delegate(this.Sub);
            }
            public int Add(int a,int b)
            {
                return a + b;
            }
            public int Sub(int a,int b)
            {
                return a - b;
            }
            static void Main(string[] args)
            {
                EventExample eventExample = new EventExample();
                int result1 = eventExample.myEvent1(2, 2);
                 int result2 = eventExample.myEvent2(9, 5);

                Console.WriteLine("Addition : " + result1);
                 Console.WriteLine("Subtraction: " + result2);
            }

        }
    
}
