using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    internal class Icosaedro : Poliedros
    {
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public Icosaedro()
        {
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniIcosaedro()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMETRICO ICOSAEDRO");
            Console.WriteLine("Se efectuará: Área total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Para esto por favor le solicitaremos una serie de datos.");

            Console.WriteLine("\nPor favor ingrese la longitud de la arista del icosaedro:");
            _arista = Verificador.VerificarDouble();

            // Área total
            double areaTotalIcosaedro = 5 * _arista * _arista * Math.Sqrt(3);

            // Volumen
            double volumenIcosaedro = (5.0 / 12.0) * (3 + Math.Sqrt(5)) * Math.Pow(_arista, 3);

            areaTotal.DefinirAreaTotal(areaTotalIcosaedro);
            Volumen.DefinirVolumen(volumenIcosaedro);
        }

        public override void MostrarPoliedro()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su icosaedro realizados correctamente!");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
