using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    internal class Octaedro : Poliedros
    {
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public Octaedro()
        {
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniOctaedro()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMETRICO OCTAEDRO");
            Console.WriteLine("Se efectuará: Área total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Para esto por favor le solicitaremos una serie de datos.");

            Console.WriteLine("\nPor favor ingrese la longitud de la arista del octaedro:");
            _arista = Verificador.VerificarDouble();

            double areaTotalOctaedro = 2 * _arista * _arista * Math.Sqrt(3);
            double volumenOctaedro = (Math.Sqrt(2) / 3) * Math.Pow(_arista, 3);

            areaTotal.DefinirAreaTotal(areaTotalOctaedro);
            Volumen.DefinirVolumen(volumenOctaedro);
        }

        public override void MostrarPoliedro()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su octaedro realizados correctamente!");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
