using System.Collections.Generic;
using System.Linq;

namespace Roma.Core.Model
{
    public static class ConcesionFactory
    {
        public static IEnumerable<IConcesion> GetAllConcesiones()
        {
            foreach(int i in Enumerable.Range(0, 6))
                yield return new ConcesionImpuestos(i, 2, i);
            yield return new ConcesionMinas(7);
            yield return new ConcesionArmamento(8);
            yield return new ConcesionAstilleros(9);
            yield return new ConcesionTerrateniente(10);
            yield return new ConcesionAduanas(11);
            yield return new ConcesionGrano(12, "Grano siciliano", 4);
            yield return new ConcesionGrano(13, "Grano egipcio", 5);
        }
    }
}
