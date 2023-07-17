namespace Roma.Core.Model
{
    public class ConcesionAstilleros :Concesion
    {
        public override int NumCartas => 1;
        public ConcesionAstilleros(int id) : base(id, "Astilleros", 3, MomentoActivacion.ReclutamientoFlotas) { }
        public override bool DestruiblePorDesastreNatrual() => true;
    }
}
