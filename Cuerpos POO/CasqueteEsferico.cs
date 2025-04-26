using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    class CasqueteEsferico : Redondos
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public CasqueteEsferico()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniCasqueteEsferico()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMÉTRICO: CASQUETE ESFÉRICO");
            Console.WriteLine("Se efectuará: Área superficial (curva) y volumen.");
            Console.WriteLine("============================================");

            Console.WriteLine("Ingrese el radio de la esfera:");
            _radio = Verificador.VerificarDouble();

            Console.WriteLine("Ingrese la altura del casquete:");
            _altura = Verificador.VerificarDouble();

            // Área superficial curva: 2πRh
            double areaCurva = 2 * Math.PI * _radio * _altura;

            // Volumen del casquete: (πh²(3R - h)) / 6
            double volumenCasquete = (Math.PI * Math.Pow(_altura, 2) * (3 * _radio - _altura)) / 6;

            areaLateral.DefinirAreaLateral(areaCurva);
            areaTotal.DefinirAreaTotal(areaCurva); // Solo curva, no base circular
            Volumen.DefinirVolumen(volumenCasquete);
        }

        public override void MostrarCuerpoRedondo()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su casquete esférico realizados correctamente!");
            Console.WriteLine($"Área superficial curva: {areaLateral.UtilizarAreaLateral():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
