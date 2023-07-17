namespace Roma.Core.Model
{
    public class ConcesionTerrateniente : Concesion
    {
        public override int NumCartas => 1;
        public ConcesionTerrateniente(int id) : base(id, "Terrateniente", 3, MomentoActivacion.FaseIngresos) { }
        public override bool RequisadaPorLandBill() => false;
        public override bool Destruible() => false;
    }
}
