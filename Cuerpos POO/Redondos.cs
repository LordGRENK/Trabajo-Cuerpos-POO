using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuerpos_POO
{
    public abstract class Redondos : CuerposGeometricos
    {
        protected string _NombreCuerpo { get; set; }
        protected double _radio { get; set; }
        protected double _AreaBase { get; set; } 
        protected double _altura { get; set; }
        protected double _generatriz { get; set; } // útil para cono, tronco de cono, etc.
        protected double _angulo { get; set; } // útil para huso o cuña esférica
        protected double _radioMayor { get; set; } // para zona y tronco
        protected double _radioMenor { get; set; } // para zona y tronco

        public override string _TipoCuerpo { get; protected set; }

        // Constructor o método que establezca el tipo
        public void TipoCuerpo()
        {
            _TipoCuerpo = "Cuerpo Redondo";
        }

        // Método abstracto a implementar por las clases derivadas
        public abstract void MostrarCuerpoRedondo();
    }
}
