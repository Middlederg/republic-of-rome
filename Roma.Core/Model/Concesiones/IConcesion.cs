using System.Collections.Generic;

namespace Roma.Core.Model
{
    public interface IConcesion
    {
        int Id { get;  }
        string Titulo { get; }
        MomentoActivacion Momento { get; }
        int Talentos { get; }
        bool Utilizada { get; set; }

        (int talentos, int popularidad) Cobrar(MomentoActivacion momento, int multiplicador = 1, bool explotar = false, NivelSequia sequia = NivelSequia.SinSequia);
        bool Destruible();
        bool Destruida(IEnumerable<IGuerra> guerrasActivas);
        bool DestruiblePorDesastreNatrual();
        bool RequisadaPorLandBill();
    }
}