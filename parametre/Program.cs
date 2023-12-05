
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametre
{
    class Sinifim
    {
        public void Selamla(string ad = "roronoa zoro")
        {
            Console.WriteLine("Kon'nichiwa " + ad);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinifim s = new Sinifim();
            s.Selamla();
            s.Selamla("monkey D. luffy");
        }
    }
}
