using System.Collections.Generic;

namespace Roma.Core.Model
{
    public interface IGuerra
    {
        string Nombre { get; }
        string Epoca { get; }
        TipoGuerra Tipo { get; }
        IEnumerable<int> Desastre { get; }
        IEnumerable<int> Rechazo { get; }
        int Botin { get; }
        bool Sequia { get; }

        int FuerzaMaritima { get; }
        int FuerzaTerrestre { get; }
    }
}
