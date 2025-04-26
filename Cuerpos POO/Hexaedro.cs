using System;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    internal class Hexaedro : Poliedros
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public Hexaedro()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniHexaedro()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMETRICO HEXAEDRO (CUBO)");
            Console.WriteLine("Se efectuará: Área lateral, total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Para esto por favor le solicitaremos una serie de datos.");

            Console.WriteLine("\nPor favor ingrese la longitud de una arista del cubo:");
            _arista = Verificador.VerificarDouble();

            double areaCara = _arista * _arista;

            areaLateral.DefinirAreaLateral(4 * areaCara);
            areaTotal.DefinirAreaTotal(6 * areaCara);
            Volumen.DefinirVolumen(_arista * _arista * _arista);
        }

        public override void MostrarPoliedro()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su hexaedro (cubo) realizados correctamente!");
            Console.WriteLine($"Área lateral: {areaLateral.UtilizarAreaLateral():F2} unidades cuadradas");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
