using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singletonp
    {
         private static Singletonp instancia;
         private string profesion;
         private int añolaboral;
         private Singletonp() 
         {
            profesion = " ";
            añolaboral = 12;
         }
         public static Singletonp Obteninstancia()
         {
            if (instancia == null)
            {
                instancia = new Singletonp();
                Console.WriteLine("Instancia nueva");
            }
            return instancia;
         }
        public override string ToString()
        {
            return string.Format("La profesion es {0} y el año laboral es {1}", profesion, añolaboral);
        }
        public void datoss(string dprofesion, int dañolaboral)
        {
            profesion = dprofesion;
            añolaboral = dañolaboral;
        }
    }
}
