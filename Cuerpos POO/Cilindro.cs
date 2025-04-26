using System;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    class Cilindro : Redondos
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public Cilindro()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniCilindro()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMÉTRICO: CILINDRO");
            Console.WriteLine("Se efectuará: Área lateral, total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Por favor ingrese los siguientes datos:");

            Console.WriteLine("\nIngrese el radio de la base del cilindro:");
            _radio = Verificador.VerificarDouble();

            Console.WriteLine("\nIngrese la altura del cilindro:");
            _altura = Verificador.VerificarDouble();

            _AreaBase = Math.PI * Math.Pow(_radio, 2);
            double areaLateralCalculada = 2 * Math.PI * _radio * _altura;
            double areaTotalCalculada = areaLateralCalculada + 2 * _AreaBase;
            double volumenCalculado = _AreaBase * _altura;

            areaLateral.DefinirAreaLateral(areaLateralCalculada);
            areaTotal.DefinirAreaTotal(areaTotalCalculada);
            Volumen.DefinirVolumen(volumenCalculado);
        }

        public override void MostrarCuerpoRedondo()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su cilindro realizados correctamente!");
            Console.WriteLine($"Área lateral: {areaLateral.UtilizarAreaLateral():F2} unidades cuadradas");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
