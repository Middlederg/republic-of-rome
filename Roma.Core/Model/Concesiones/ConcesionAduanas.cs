namespace Roma.Core.Model
{
    public class ConcesionAduanas : Concesion
    {
        public override int NumCartas => 1;
        public ConcesionAduanas(int id) : base(id, "Aduanas", 3, MomentoActivacion.FaseIngresos) { }
        public override bool DestruiblePorDesastreNatrual() => true;
    }
}
