using System;

namespace Roma.Core.Model
{
    public class ConcesionGrano : Concesion
    {
        public override int NumCartas => 2;
        public ConcesionGrano(int id, string titulo, int talentos) : base(id, titulo, talentos, MomentoActivacion.FaseIngresos) { }
        public override (int talentos, int popularidad) Cobrar(MomentoActivacion momento, int multiplicador = 1, bool explotar = false, NivelSequia sequia = NivelSequia.SinSequia)
        {
            if (!momento.Equals(Momento))
                throw new Exception($"Solo se puede activar la concesión en {Momento.ToString()}");

            multiplicador = (explotar && !sequia.Equals(NivelSequia.SinSequia)) ? 2 : 1;
            int sumatorio = ((int)sequia) - 1;
            Utilizada = true;
            return ((Talentos + sumatorio) * multiplicador, (explotar ? -2 : 0) - sumatorio);
        }
    }
}
