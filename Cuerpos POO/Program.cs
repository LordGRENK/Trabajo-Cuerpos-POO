using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuerpos_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Prisma = new Prisma();
            var Piramide = new Piramide();
            Piramide.IniPiramide();
            Piramide.MostrarPoliedro();
        }
    }
}
