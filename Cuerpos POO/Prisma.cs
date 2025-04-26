using System;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    internal class Prisma : Poliedros
    {
        private AreaLateral areaLateral;
        private AreaTotal areaTotal;
        private Volumen Volumen;
        private Verificadores Verificador;

        public Prisma()
        {
            areaLateral = new AreaLateral();
            areaTotal = new AreaTotal();
            Volumen = new Volumen();
            Verificador = new Verificadores();
        }
        public void IniPrisma()
        {

            int respuesta = 0;


            Console.WriteLine("TRABAJANDO CON CUERPO GEOMETRICO PRISMA");
            Console.WriteLine("Se efectuara: Area lateral, total y volumen.");
            Console.WriteLine("============================================");
            Console.WriteLine("Para esto porfavor le solicitaremos una serie de datos.");
            Console.WriteLine("Usted cuenta con el perimetro de la base 1. Si 2. No");
            respuesta = Verificador.VerificarSiNo();
            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Porfavor ingrese el perimetro de la base");
                    _perimetrobase = Verificador.VerificarDouble();
                    break;
                case 2:
                    Console.WriteLine("Porfavor numero de lados");
                    _NumeroCaras = Verificador.VerificarEntero();
                    Console.WriteLine("Porfavor ingrese la longitud de los lados:");
                    _longitud = Verificador.VerificarDouble();
                    _perimetrobase = _NumeroCaras * _longitud;
                    break;

            }
            Console.WriteLine("\nPor favor ingrese la altura");
            _altura = Verificador.VerificarDouble();
            Console.WriteLine("\n Favor ingresar el apotema del prisma");
            _apotema = Verificador.VerificarDouble();
            _AreaBase = (_perimetrobase * _apotema) / 2;
            areaLateral.DefinirAreaLateral(_perimetrobase * _altura);
            areaTotal.DefinirAreaTotal(areaLateral.UtilizarAreaLateral()+(2*_AreaBase));
            Volumen.DefinirVolumen(_AreaBase * _altura);


        }
        public override void MostrarPoliedro()
        {
            
            Console.WriteLine("Calculos de su prisma realizados correctamente!!");
            Console.WriteLine($"El area lateral de su prisma es de: {areaLateral.UtilizarAreaLateral()}");
            Console.WriteLine($"El area total de su prisma es de: {areaTotal.UtilizarAreaTotal()}");
            Console.WriteLine($"El volumen de su prisma es de: {Volumen.UtilizarVolumen()}");
        }
    }
}
