using System;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    class Esfera : Redondos
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public Esfera()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniEsfera()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMÉTRICO: ESFERA");
            Console.WriteLine("Se efectuará: Área superficial (lateral y total) y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Por favor ingrese el radio de la esfera:");

            _radio = Verificador.VerificarDouble();

            double areaSuperficial = 4 * Math.PI * Math.Pow(_radio, 2);
            double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(_radio, 3);

            areaLateral.DefinirAreaLateral(areaSuperficial);
            areaTotal.DefinirAreaTotal(areaSuperficial);
            Volumen.DefinirVolumen(volumen);
        }

        public override void MostrarCuerpoRedondo()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su esfera realizados correctamente!");
            Console.WriteLine($"Área superficial: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
