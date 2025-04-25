namespace Cuerpos_POO
{
    internal class Volumen
    {
        private double _volumen;

        public void DefinirVolumen(double volumen)
        {
            _volumen = volumen;
        }
        public double UtilizarVolumen()
        {
            return _volumen;
        }
    }
}
