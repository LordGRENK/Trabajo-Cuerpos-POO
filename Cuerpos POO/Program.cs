using System;
using POO_Cuerpos_Geometricos;

namespace Cuerpos_POO
{
    internal class Program
    {
        static Verificadores Verificador = new Verificadores();

        // Poliedros
        static Prisma prisma = new Prisma();
        static Piramide piramide = new Piramide();
        static Ortoedro ortoedro = new Ortoedro();
        static Tetraedro tetraedro = new Tetraedro();
        static Hexaedro hexaedro = new Hexaedro();
        static Octaedro octaedro = new Octaedro();
        static Dodecaedro dodecaedro = new Dodecaedro();
        static Icosaedro icosaedro = new Icosaedro();
        static TroncoPiramide troncoPiramide = new TroncoPiramide();

        // Cuerpos redondos
        static Cilindro cilindro = new Cilindro();
        static Cono cono = new Cono();
        static Esfera esfera = new Esfera();
        static ZonaEsferica zonaEsferica = new ZonaEsferica();
        static CasqueteEsferico casqueteEsferico = new CasqueteEsferico();
        static CasqueteYCunaEsferica casqueteYCunaEsferica = new CasqueteYCunaEsferica();
        static TroncoDeCono troncoDeCono = new TroncoDeCono();

        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            int opcion = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Poliedros");
                Console.WriteLine("2. Cuerpos Redondos");
                Console.WriteLine("0. Salir");
                Console.WriteLine("======================");
                Console.WriteLine("Seleccione una opción:");
                opcion = Verificador.VerificarEntero(true);

                switch (opcion)
                {
                    case 1:
                        MenuPoliedros();
                        break;
                    case 2:
                        MenuRedondos();
                        break;
                    case 0:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 0);
        }

        static void MenuPoliedros()
        {
            int opcion = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("--- POLIEDROS ---");
                Console.WriteLine("1. Prisma");
                Console.WriteLine("2. Pirámide");
                Console.WriteLine("3. Ortoedro");
                Console.WriteLine("4. Tetraedro");
                Console.WriteLine("5. Hexaedro");
                Console.WriteLine("6. Octaedro");
                Console.WriteLine("7. Dodecaedro");
                Console.WriteLine("8. Icosaedro");
                Console.WriteLine("9. Tronco de Pirámide");
                Console.WriteLine("0. Volver al menú principal");
                Console.WriteLine("======================");
                Console.WriteLine("Seleccione una opción:");
                opcion = Verificador.VerificarEntero(true);

                switch (opcion)
                {
                    case 1: prisma.IniPrisma(); prisma.MostrarPoliedro(); break;
                    case 2: piramide.IniPiramide(); piramide.MostrarPoliedro(); break;
                    case 3: ortoedro.IniOrtoedro(); ortoedro.MostrarPoliedro(); break;
                    case 4: tetraedro.IniTetraedro(); tetraedro.MostrarPoliedro(); break;
                    case 5: hexaedro.IniHexaedro(); hexaedro.MostrarPoliedro(); break;
                    case 6: octaedro.IniOctaedro(); octaedro.MostrarPoliedro(); break;
                    case 7: dodecaedro.IniDodecaedro(); dodecaedro.MostrarPoliedro(); break;
                    case 8: icosaedro.IniIcosaedro(); icosaedro.MostrarPoliedro(); break;
                    case 9: troncoPiramide.IniTroncoPiramide(); troncoPiramide.MostrarPoliedro(); break;
                    case 0: break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo...");
                        Console.ReadKey();
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        static void MenuRedondos()
        {
            int opcion = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("--- CUERPOS REDONDOS ---");
                Console.WriteLine("1. Cilindro");
                Console.WriteLine("2. Cono");
                Console.WriteLine("3. Esfera");
                Console.WriteLine("4. Zona Esférica");
                Console.WriteLine("5. Casquete Esférico");
                Console.WriteLine("6. Casquete y Cuña Esférica");
                Console.WriteLine("7. Tronco de Cono");
                Console.WriteLine("0. Volver al menú principal");
                Console.WriteLine("======================");
                Console.WriteLine("Seleccione una opción:");
                opcion = Verificador.VerificarEntero(true);

                switch (opcion)
                {
                    case 1: cilindro.IniCilindro(); cilindro.MostrarCuerpoRedondo(); break;
                    case 2: cono.IniCono(); cono.MostrarCuerpoRedondo(); break;
                    case 3: esfera.IniEsfera(); esfera.MostrarCuerpoRedondo(); break;
                    case 4: zonaEsferica.IniZonaEsferica(); zonaEsferica.MostrarCuerpoRedondo(); break;
                    case 5: casqueteEsferico.IniCasqueteEsferico(); casqueteEsferico.MostrarCuerpoRedondo(); break;
                    case 6: casqueteYCunaEsferica.IniCasqueteYCunaEsferica(); casqueteYCunaEsferica.MostrarCuerpoRedondo(); break;
                    case 7: troncoDeCono.IniTroncoDeCono(); troncoDeCono.MostrarCuerpoRedondo(); break;
                    case 0: break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo...");
                        Console.ReadKey();
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}
