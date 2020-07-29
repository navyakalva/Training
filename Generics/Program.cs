using System;

namespace Generics
{
     public class GenericClass<T>

    {

        public T msg;

        public void genericMethod(T name, T location)

        {

            Console.WriteLine("{0}", msg);

            Console.WriteLine("Name: {0}", name);

            Console.WriteLine("Location: {0}", location);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

           

            // Instantiate Generic Class, string is the type argument

            GenericClass<string> gclass = new GenericClass<string>();

            gclass.msg = "Generics Example";

            gclass.genericMethod("Navya", "Hyderabad");

            Console.ReadLine();

        }

    }
}
