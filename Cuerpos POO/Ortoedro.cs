using System;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    internal class Ortoedro : Poliedros
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public Ortoedro()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }

        public void IniOrtoedro()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMETRICO ORTOEDRO");
            Console.WriteLine("Se efectuará: Área lateral, total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Para esto por favor le solicitaremos una serie de datos.");

            Console.WriteLine("\nPor favor ingrese la longitud del ortoedro:");
            _longitud = Verificador.VerificarDouble();

            Console.WriteLine("\nPor favor ingrese el ancho del ortoedro:");
            _ancho = Verificador.VerificarDouble();

            Console.WriteLine("\nPor favor ingrese la altura del ortoedro:");
            _altura = Verificador.VerificarDouble();

            areaLateral.DefinirAreaLateral(2 * (_longitud * _altura + _ancho * _altura));
            areaTotal.DefinirAreaTotal(areaLateral.UtilizarAreaLateral() + (2 * (_longitud * _ancho)));
            Volumen.DefinirVolumen(_longitud * _ancho * _altura);
        }

        public override void MostrarPoliedro()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su ortoedro realizados correctamente!");
            Console.WriteLine($"Área lateral: {areaLateral.UtilizarAreaLateral():F2} unidades cuadradas");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }
    }
}
