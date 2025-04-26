using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    class TroncoPiramide : Poliedros
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen volumen;
        private Verificadores verificador;

        private double _AreaBaseMenor;
        private double _perimetroBaseMayor;
        private double _perimetroBaseMenor;
        private double _apotemaTronco;

        public TroncoPiramide()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            volumen = new Volumen();
            verificador = new Verificadores();
        }

        public void IniTroncoPiramide()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMÉTRICO TRONCO DE PIRÁMIDE");
            Console.WriteLine("Se efectuará: Área lateral, total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Para esto por favor le solicitaremos una serie de datos.");

            Console.WriteLine("\nIngrese el área de la base mayor:");
            _AreaBase = verificador.VerificarDouble();

            Console.WriteLine("\nIngrese el área de la base menor:");
            _AreaBaseMenor = verificador.VerificarDouble();

            Console.WriteLine("\nIngrese el perímetro de la base mayor:");
            _perimetroBaseMayor = verificador.VerificarDouble();

            Console.WriteLine("\nIngrese el perímetro de la base menor:");
            _perimetroBaseMenor = verificador.VerificarDouble();

            Console.WriteLine("\nIngrese la apotema del tronco de pirámide:");
            _apotemaTronco = verificador.VerificarDouble();

            Console.WriteLine("\nIngrese la altura del tronco de pirámide:");
            _altura = verificador.VerificarDouble();
            double areaLateralCalc = ((_perimetroBaseMayor + _perimetroBaseMenor) * _apotemaTronco) / 2;
            areaLateral.DefinirAreaLateral(areaLateralCalc);

            double areaTotalCalc = areaLateral.UtilizarAreaLateral() + _AreaBase + _AreaBaseMenor;
            areaTotal.DefinirAreaTotal(areaTotalCalc);

            double volumenCalc = (_altura / 3) * (_AreaBase + _AreaBaseMenor + Math.Sqrt(_AreaBase * _AreaBaseMenor));
            volumen.DefinirVolumen(volumenCalc);
        }

        public override void MostrarPoliedro()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su tronco de pirámide realizados correctamente!");
            Console.WriteLine($"Área lateral: {areaLateral.UtilizarAreaLateral():F2} unidades cuadradas");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
