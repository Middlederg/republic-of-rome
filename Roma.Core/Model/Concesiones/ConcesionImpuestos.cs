using System.Collections.Generic;
using System.Linq;
using System;

namespace Roma.Core.Model
{
    public class ConcesionImpuestos : Concesion
    {
        public override int NumCartas => 6;
        public int NumeroDestruccion { get; private set; }
        public ConcesionImpuestos(int id, int talentos, int numeroDestruccion) : base(id, "Impuestos", talentos, MomentoActivacion.FaseIngresos)
        {
            NumeroDestruccion = numeroDestruccion;
        }

        public override bool Destruida(IEnumerable<IGuerra> guerrasActivas)
        {
            if (guerrasActivas.Any(x => x.Tipo.Equals(TipoGuerra.Punica)))
                return R.Instance.LanzarDados6() == NumeroDestruccion;
            return false;
        }
    }
}
