using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    class TroncoDeCono : Redondos
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public TroncoDeCono()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniTroncoDeCono()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMÉTRICO: TRONCO DE CONO");
            Console.WriteLine("Se efectuará: Área lateral, área total y volumen.");
            Console.WriteLine("============================================");

            // Solicitar datos
            Console.WriteLine("Ingrese el radio de la base mayor (r1):");
            double radioMayor = Verificador.VerificarDouble();

            Console.WriteLine("Ingrese el radio de la base menor (r2):");
            double radioMenor = Verificador.VerificarDouble();

            Console.WriteLine("Ingrese la altura del tronco de cono (h):");
            double altura = Verificador.VerificarDouble();

            // Calcular la generatriz (l) con el teorema de Pitágoras
            double generatriz = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(radioMayor - radioMenor, 2));

            // Calcular área lateral: π(r1 + r2) * l
            double areaLateralCono = Math.PI * (radioMayor + radioMenor) * generatriz;

            // Calcular área total: Área lateral + Área de las bases
            double areaBaseMayor = Math.PI * Math.Pow(radioMayor, 2);
            double areaBaseMenor = Math.PI * Math.Pow(radioMenor, 2);
            double areaTotalCono = areaLateralCono + areaBaseMayor + areaBaseMenor;

            // Calcular volumen: (1/3)πh(r1^2 + r1 * r2 + r2^2)
            double volumenCono = (1.0 / 3.0) * Math.PI * altura * (Math.Pow(radioMayor, 2) + (radioMayor * radioMenor) + Math.Pow(radioMenor, 2));

            // Asignar resultados
            areaLateral.DefinirAreaLateral(areaLateralCono);
            areaTotal.DefinirAreaTotal(areaTotalCono);
            Volumen.DefinirVolumen(volumenCono);
        }

        public override void MostrarCuerpoRedondo()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine($"Área lateral: {areaLateral.UtilizarAreaLateral():F2} unidades cuadradas");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
