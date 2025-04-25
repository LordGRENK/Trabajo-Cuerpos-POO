using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuerpos_POO
{
    internal class Redondos : CuerposGeometricos
    {
        public override string _TipoCuerpo { get; protected set; }
        //Constructor
        public void TipoCuerpo()
        {
            _TipoCuerpo = "Redondo";
        }
    }
}
