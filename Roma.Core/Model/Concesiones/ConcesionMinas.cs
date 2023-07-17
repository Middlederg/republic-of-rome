namespace Roma.Core.Model
{
    public class ConcesionMinas : Concesion
    {
        public override int NumCartas => 1;
        public ConcesionMinas(int id) : base(id, "Minas", 3, MomentoActivacion.FaseIngresos) { }
        public override bool DestruiblePorDesastreNatrual() => true;
    }
}
