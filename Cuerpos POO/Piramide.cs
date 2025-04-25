using System;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    class Piramide : Poliedros
    {
        private AreaLateral areaLateral;
		private AreaTotal areaTotal;
		private Volumen Volumen;
		private Verificadores Verificador;

		public Piramide()
		{
			areaLateral = new AreaLateral();
			areaTotal = new AreaTotal();
			Volumen = new Volumen();
			Verificador = new Verificadores();
		}
        public void IniPiramide()
        {
            Console.WriteLine("TRABAJANDO CON CUERPO GEOMETRICO PIRAMIDE");
            Console.WriteLine("Se efectuará: Área lateral, total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Para esto por favor le solicitaremos una serie de datos.");
            Console.WriteLine("\n¿Desea ingresar manualmente el área de la base? (S/N)");
            string respuesta = Console.ReadLine();
            if (respuesta == "S" || respuesta == "s")
            {
                Console.WriteLine("\nIngrese el área de la base directamente:");
                _AreaBase = Verificador.VerificarDouble();
            }
            else
            {
                Console.WriteLine("\nIngrese el perímetro de la base:");
                _perimetrobase = Verificador.VerificarDouble();

                Console.WriteLine("\nIngrese la apotema de la base:");
                _apotema = Verificador.VerificarDouble();

                _AreaBase = (_perimetrobase * _apotema) / 2;
            }
            Console.WriteLine("\nIngrese la apotema de la pirámide (altura inclinada de las caras laterales):");
            _apotemaPiramide = Verificador.VerificarDouble();
            Console.WriteLine("\nIngrese la altura de la pirámide (del vértice al centro de la base):");
            _altura = Verificador.VerificarDouble();
            areaLateral.DefinirAreaLateral((_perimetrobase * _apotemaPiramide) / 2);
            areaTotal.DefinirAreaTotal(areaLateral.UtilizarAreaLateral() + _AreaBase);
            Volumen.DefinirVolumen((_AreaBase * _altura) / 3);
        }
        public override void MostrarPoliedro()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("¡Cálculos de su pirámide realizados correctamente!");
            Console.WriteLine($"Área lateral: {areaLateral.UtilizarAreaLateral():F2} unidades cuadradas");
            Console.WriteLine($"Área total: {areaTotal.UtilizarAreaTotal():F2} unidades cuadradas");
            Console.WriteLine($"Volumen: {Volumen.UtilizarVolumen():F2} unidades cúbicas");
            Console.WriteLine("============================================\n");
        }

    }
}

