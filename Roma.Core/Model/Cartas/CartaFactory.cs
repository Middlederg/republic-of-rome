using System.Collections.Generic;
using System.Linq;

namespace Roma.Core.Model.Cartas
{
    public static class CartaFactory
    {
        private static IEnumerable<ICarta> GetAllCards<T>()
        {
            foreach (var n in Enumerable.Range(0, 9))
                yield return new Tribuno();
            yield return new Asesino();
            yield return new Chantaje();
            yield return new TraficoInfluencias();
            yield return new Seduccion();
            yield return new Guardaespaldas();
        }
    }
}
