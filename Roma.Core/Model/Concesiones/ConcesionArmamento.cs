namespace Roma.Core.Model
{
    public class ConcesionArmamento : Concesion
    {
        public override int NumCartas => 1;
        public ConcesionArmamento(int id) : base(id, "Armamento", 2, MomentoActivacion.ReclutamientoLegiones) { }
        public override bool DestruiblePorDesastreNatrual() => true;
    }
}
