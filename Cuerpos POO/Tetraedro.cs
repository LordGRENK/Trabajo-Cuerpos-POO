using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    internal class Tetraedro : Poliedros
    {
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public Tetraedro()
        {
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniTetraedro()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMETRICO TETRAEDRO");
            Console.WriteLine("Se efectuará: Área total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Para esto por favor le solicitaremos una serie de datos.");

            Console.WriteLine("\nPor favor ingrese la longitud de la arista del tetraedro:");
            _arista = Verificador.VerificarDouble();

            // Área de un triángulo equilátero: (lado^2 * sqrt(3)) / 4
            double areaUnaCara = (_arista * _arista * Math.Sqrt(3)) / 4;
            double areaTotalTetraedro = areaUnaCara * 4;

            areaTotal.DefinirAreaTotal(areaTotalTetraedro);

            // Volumen de un tetraedro regular: (lado^3) / (6√2)
            double volumenTetraedro = (_arista * _arista * _arista) / (6 * Math.Sqrt(2));

            Volumen.DefinirVolumen(volumenTetraedro);
        }

        public override void MostrarPoliedro()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su tetraedro realizados correctamente!");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
