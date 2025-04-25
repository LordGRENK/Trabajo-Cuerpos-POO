using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuerpos_POO
{
    internal class AreaTotal
    {
        private double _areaTotal;
        public void DefinirAreaTotal(double areaTotal)
        {
            _areaTotal = areaTotal;
        }
        public double UtilizarAreaTotal()
        {
            return _areaTotal;
        }
    }
}
