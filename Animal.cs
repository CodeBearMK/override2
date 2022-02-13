using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override2
{
    internal class Animal
    {
        protected string kind = "動物";
        public string Mammal { get; set; }

        public virtual void display()
        {
            Console.WriteLine("{0} 是 {1}", Mammal, kind);
            Console.WriteLine("-------------------------");
        }
    }
}
