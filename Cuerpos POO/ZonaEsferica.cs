using System;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    class ZonaEsferica : Redondos
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public ZonaEsferica()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniZonaEsferica()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMÉTRICO: ZONA ESFÉRICA");
            Console.WriteLine("Se efectuará: Área lateral (superficial) y volumen.");
            Console.WriteLine("============================================");

            Console.WriteLine("Ingrese el radio de la esfera:");
            _radio = Verificador.VerificarDouble();

            Console.WriteLine("Ingrese la altura de la zona esférica:");
            _altura = Verificador.VerificarDouble();
            double areaLateralZona = 2 * Math.PI * _radio * _altura;
            double volumenZona = (Math.PI * Math.Pow(_altura, 2) * (3 * _radio - _altura)) / 6;

            areaLateral.DefinirAreaLateral(areaLateralZona);
            areaTotal.DefinirAreaTotal(areaLateralZona);
            Volumen.DefinirVolumen(volumenZona);
        }

        public override void MostrarCuerpoRedondo()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su zona esférica realizados correctamente!");
            Console.WriteLine($"Área lateral: {areaLateral.UtilizarAreaLateral():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
