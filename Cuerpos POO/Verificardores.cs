using System;

namespace POO_Cuerpos_Geometricos
{
    class Verificadores
    {
        public int VerificarEntero(bool permitirCero = false)
        {
            int resultado;
            bool esValido = false;
            do
            {
                Console.Write("-> ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out resultado))
                {
                    if (resultado > 0 || (permitirCero && resultado == 0))
                    {
                        esValido = true;
                    }
                    else
                    {
                        MostrarMensajeError(permitirCero ? "Ingrese un número mayor o igual a 0." : "Ingrese un número mayor que 0.");
                    }
                }
                else
                {
                    MostrarMensajeError("Debe ingresar un número entero válido.");
                }
            } while (!esValido);
            return resultado;
        }

        public int VerificarSiNo()
        {
            int resultado;
            bool esValido = false;
            do
            {
                Console.Write("-> ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out resultado))
                {
                    if (resultado == 1 || resultado == 2)
                    {
                        esValido = true;
                    }
                    else
                    {
                        MostrarMensajeError("Solo puede ingresar 1 (Sí) o 2 (No).");
                    }
                }
                else
                {
                    MostrarMensajeError("Debe ingresar 1 o 2.");
                }
            } while (!esValido);
            return resultado;
        }

        public double VerificarDouble(bool permitirCero = false)
        {
            double resultado;
            bool esValido = false;
            do
            {
                Console.Write("-> ");
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, out resultado))
                {
                    if (resultado > 0 || (permitirCero && resultado == 0))
                    {
                        esValido = true;
                    }
                    else
                    {
                        MostrarMensajeError(permitirCero ? "Ingrese un número mayor o igual a 0." : "Ingrese un número mayor que 0.");
                    }
                }
                else
                {
                    MostrarMensajeError("Debe ingresar un número decimal válido.");
                }
            } while (!esValido);
            return resultado;
        }

        private void MostrarMensajeError(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("Pulse una tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}

