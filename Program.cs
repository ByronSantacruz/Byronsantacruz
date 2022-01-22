using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
           Singletonp singletonp = Singletonp.Obteninstancia();
            singletonp.datoss("Ingeniero en TI", 8);
            Console.WriteLine(singletonp);
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
    
}
