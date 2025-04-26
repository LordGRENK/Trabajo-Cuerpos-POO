namespace Cuerpos_POO
{
    public abstract class Redondos : CuerposGeometricos
    {
        protected string _NombreCuerpo { get; set; }
        protected double _radio { get; set; }
        protected double _AreaBase { get; set; } 
        protected double _altura { get; set; }
        protected double _generatriz { get; set; } 
        protected double _angulo { get; set; } 
        protected double _radioMayor { get; set; } 
        protected double _radioMenor { get; set; }
        public override string _TipoCuerpo { get; protected set; }
        public void TipoCuerpo()
        {
            _TipoCuerpo = "Cuerpo Redondo";
        }
        public abstract void MostrarCuerpoRedondo();
    }
}
