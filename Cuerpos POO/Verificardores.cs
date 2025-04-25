using System;

namespace POO_Cuerpos_Geometricos
{
    class Verificadores
    {
        private int _retorno = 0;
        private double _RetornoDOuble = 0;
        public int VerificarEntero()
        {
            string entero = "";
            bool Verifi = false;
            {
                do
                {
                    Console.Write("->");
                    entero = Console.ReadLine();
                    if (int.TryParse(entero, out int numero))
                    {
                        _retorno = Convert.ToInt32(entero);
                        if (_retorno > 0)
                        {
                            Verifi = true;
                        }
                        else
                        {
                            Console.WriteLine("Porfavor ingrese un numero correcto");
                            Console.Write("Pulse una tecla para continuar. . ."); Console.ReadKey();
                            Console.WriteLine("");
                        }
                        Verifi = true;
                    }
                    else
                    {
                        Console.WriteLine("Porfavor ingrese un numero correcto");
                        Console.Write("Pulse una tecla para continuar. . ."); Console.ReadKey();
                        Console.WriteLine("");

                    }
                } while (!Verifi);
                return _retorno;
            }
        }
        public int VerificarSiNo()
        {
            string entero = "";
            bool Verifi = false;
            {
                do
                {
                    Console.Write("->");
                    entero = Console.ReadLine();
                    if (int.TryParse(entero, out int numero))
                    {
                        _retorno = Convert.ToInt32(entero);
                        if (_retorno == 1 || _retorno == 2)
                        {
                            Verifi = true;
                        }
                        else
                        {
                            Console.WriteLine("Porfavor ingrese un numero correcto");
                            Console.Write("Pulse una tecla para continuar. . ."); Console.ReadKey();
                            Console.WriteLine("");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Porfavor ingrese un numero correcto");
                        Console.Write("Pulse una tecla para continuar. . ."); Console.ReadKey();
                        Console.WriteLine("");
                    }

                } while (!Verifi);
                return _retorno;
            }
        }
        public double VerificarDouble()
        {
            string _double1 = "";
            bool Verifi = false;
            {
                do
                {
                    Console.Write("->");
                    _double1 = Console.ReadLine();
                    if (double.TryParse(_double1, out double numero))
                    {
                        _RetornoDOuble = Convert.ToDouble(_double1);
                        if (_RetornoDOuble > 0)
                        {
                            Verifi = true;
                        }
                        else
                        {
                            Console.WriteLine("Porfavor ingrese un numero correcto");
                            Console.Write("Pulse una tecla para continuar. . ."); Console.ReadKey();
                            Console.WriteLine("");
                        }
                        Verifi = true;
                    }
                    else
                    {
                        Console.WriteLine("Porfavor ingrese un numero correcto");
                        Console.Write("Pulse una tecla para continuar. . ."); Console.ReadKey();
                        Console.WriteLine("");

                    }
                } while (!Verifi);
                return _RetornoDOuble;
            }
        }
    }
}

