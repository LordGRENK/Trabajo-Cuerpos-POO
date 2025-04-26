namespace Cuerpos_POO
{
        public abstract class Poliedros : CuerposGeometricos
        {
        protected string _NombreCuerpo { get; set; }
        protected double _ancho { get; set; }
        protected double _arista { get; set; }
        protected double _AreaBase { get; set; }
        protected double _longitud { get; set; }
        protected int _NumeroCaras { get; set; }
        protected int _NumeroAristas { get; set; }
        protected int _NumeroVertices { get; set; }
        protected double _apotema { get; set; }
        protected double _altura { get; set; }
        protected double _apotemaPiramide { get; set; }

        protected double _perimetrobase { get; set; }
        protected double _baseMenor { get; set; }

        public override string _TipoCuerpo { get; protected set; }

        //Constructor
        public void TipoCuerpo()
        {
            _TipoCuerpo = "Poliedro";
        }
        public abstract void MostrarPoliedro();
    }
}
