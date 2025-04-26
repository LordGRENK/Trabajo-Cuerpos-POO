using System;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    internal class Dodecaedro : Poliedros
    {
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public Dodecaedro()
        {
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniDodecaedro()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMETRICO DODECAEDRO");
            Console.WriteLine("Se efectuará: Área total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Para esto por favor le solicitaremos una serie de datos.");

            Console.WriteLine("\nPor favor ingrese la longitud de la arista del dodecaedro:");
            _arista = Verificador.VerificarDouble();

            // Área total
            double cotPiSobre5 = 1 / Math.Tan(Math.PI / 5);
            double areaTotalDodecaedro = 15 * _arista * _arista * cotPiSobre5;

            // Volumen
            double volumenDodecaedro = (1.0 / 4.0) * (15 + 7 * Math.Sqrt(5)) * Math.Pow(_arista, 3);

            areaTotal.DefinirAreaTotal(areaTotalDodecaedro);
            Volumen.DefinirVolumen(volumenDodecaedro);
        }

        public override void MostrarPoliedro()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su dodecaedro realizados correctamente!");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
