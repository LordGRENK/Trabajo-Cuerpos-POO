using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    class Cono : Redondos
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public Cono()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniCono()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMÉTRICO: CONO");
            Console.WriteLine("Se efectuará: Área lateral, total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Por favor ingrese los siguientes datos:");

            Console.WriteLine("\nIngrese el radio de la base del cono:");
            _radio = Verificador.VerificarDouble();

            Console.WriteLine("\nIngrese la altura del cono (del vértice al centro de la base):");
            _altura = Verificador.VerificarDouble();

            Console.WriteLine("\nIngrese la generatriz (la línea inclinada desde el vértice al borde del círculo):");
            _generatriz = Verificador.VerificarDouble();

            _AreaBase = Math.PI * Math.Pow(_radio, 2);
            double areaLateralCalculada = Math.PI * _radio * _generatriz;
            double areaTotalCalculada = areaLateralCalculada + _AreaBase;
            double volumenCalculado = (_AreaBase * _altura) / 3;

            areaLateral.DefinirAreaLateral(areaLateralCalculada);
            areaTotal.DefinirAreaTotal(areaTotalCalculada);
            Volumen.DefinirVolumen(volumenCalculado);
        }

        public override void MostrarCuerpoRedondo()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su cono realizados correctamente!");
            Console.WriteLine($"Área lateral: {areaLateral.UtilizarAreaLateral():F2} unidades cuadradas");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
