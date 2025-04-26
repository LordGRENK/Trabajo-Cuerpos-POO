using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    class CasqueteYCunaEsferica : Redondos
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public CasqueteYCunaEsferica()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniCasqueteYCunaEsferica()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMÉTRICO: CASQUETE Y CUÑA ESFÉRICA");
            Console.WriteLine("Se efectuará: Área superficial (curva) y volumen.");
            Console.WriteLine("============================================");

            Console.WriteLine("Ingrese el radio de la esfera:");
            _radio = Verificador.VerificarDouble();

            Console.WriteLine("Ingrese la altura (de casquete o cuña esférica):");
            _altura = Verificador.VerificarDouble();

            Console.WriteLine("¿Desea calcular un Casquete esférico (C) o una Cuña esférica (E)? Ingrese C o E:");
            string tipo = Console.ReadLine().ToUpper();

            if (tipo == "C")
            {
                // Casquete Esférico
                Console.WriteLine("Calculando Casquete Esférico...");
                double areaCurvaCasquete = 2 * Math.PI * _radio * _altura;
                double volumenCasquete = (Math.PI * Math.Pow(_altura, 2) * (3 * _radio - _altura)) / 6;

                areaLateral.DefinirAreaLateral(areaCurvaCasquete);
                areaTotal.DefinirAreaTotal(areaCurvaCasquete);
                Volumen.DefinirVolumen(volumenCasquete);
            }
            else if (tipo == "E")
            {
                // Cuña Esférica
                Console.WriteLine("Ingrese el ángulo central de la cuña (en grados):");
                double anguloGrados = Verificador.VerificarDouble();

                // Volumen de Cuña Esférica: V = (θ / 360) * (4/3)πR³
                double volumenCuna = (anguloGrados / 360) * (4 * Math.PI * Math.Pow(_radio, 3)) / 3;

                areaLateral.DefinirAreaLateral(0);  // La cuña esférica no tiene área lateral por este cálculo
                areaTotal.DefinirAreaTotal(0); // Similar a la lateral, ya que la cuña no tiene área curva simple
                Volumen.DefinirVolumen(volumenCuna);
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor ingrese 'C' para Casquete o 'E' para Cuña.");
            }
        }

        public override void MostrarCuerpoRedondo()
        {
            Console.WriteLine("\n============================================");
            if (areaLateral.UtilizarAreaLateral() != 0)
                Console.WriteLine($"Área superficial curva: {areaLateral.UtilizarAreaLateral():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
