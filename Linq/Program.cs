using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
             
           
        
            List<string> names = new List<string> { "navya", "anil", "mani" };
            List<string> frnds = names.Select(x => x.ToUpper()).ToList();
            foreach (var i in frnds)
            {
                Console.WriteLine(i);
            }
            
            List<Employ> emp = new List<Employ>
            {
                new Employ{eid=25,eName="navya",age=22,salary=95000},
                new Employ{eid=28,eName="anil",age=21,salary=87600},
                new Employ{eid=29,eName="mani",age=24,salary=65000}
            };
            var empName = emp.First(x => x.salary > 87600);
            Console.WriteLine(empName.eName);
            var em = emp.SingleOrDefault(x=>x.eid<24);
            if (em != null)
            {
                Console.WriteLine(em.eName);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            List<Employ> emp1 = emp.OrderBy(x => x.salary).ToList();
            foreach(var i in emp1)
            {
                Console.WriteLine("Employ Name " +i.eName+" Salary: "+i.salary);
            }
            
            List<Employ> emp2 = emp.OrderBy(x => x.eName).ThenByDescending(x=>x.age).ToList();
            foreach (var i in emp2)
            {
                Console.WriteLine("Employ Name " + i.eName + " Age: " + i.age);
            }
        }
    }
}
