using System.Collections.Generic;

namespace Roma.Core.Model
{
    public static class ProvinciaFactory
    {
        public static Provincia Sicilia => new Provincia("Sicilia", "Creada por 1º guerra púnica", new Formula(1, 0), new Formula(1, 4), new Formula(2, -2), new Formula(1, 2));
        public static Provincia Iliria => new Provincia("Iliria", "Creada por guerras Ilirias", new Formula(1, -3), new Formula(1, 0), new Formula(-1, -1), new Formula(1, 0));
        public static Provincia GaliaCisalpina => new Provincia("Galia Cisalpina", "Creada por 1º guerra de Las Galias", new Formula(1, -1), new Formula(1, 3), new Formula(1, -1), new Formula(2, -1));
        public static Provincia GaliaNarbonense => new Provincia("Galia Narbonense", "Creada por migración germánica", new Formula(1, -3), new Formula(1, 1), new Formula(1, -3), new Formula(1, 1));
        public static Provincia CiliciaChipre => new Provincia("Cilicia y Chipre", "Creada por primeros piratas cilicios", new Formula(1, -1), new Formula(1, 0), new Formula(-1, 0), new Formula(-1, 3));
        public static Provincia HispaniaCiterior => new Provincia("Hispania Citerior", "Creada por 2º guerra púnica", new Formula(1, -2), new Formula(1, 2), new Formula(-1, 1), new Formula(1, 1));
        public static Provincia Bitinia => new Provincia("Bitinia", "Creada por la conquista de Bitinia", new Formula(1, -4), new Formula(1, 2), new Formula(1, -2), new Formula(1, 2));
        public static Provincia HispaniaUlterior => new Provincia("Hispania Ulterior", "Creada por 2º guerra púnica", new Formula(1, -3), new Formula(1, 1), new Formula(-1, -1), new Formula(1, -1));
        public static Provincia GaliaTransalpina => new Provincia("Galia Transalpina", "Creada por la 2º o 3º guerra de Las Galias", new Formula(1, -4), new Formula(1, 0), new Formula(1, -5), new Formula(1, 1));
        public static Provincia Macedonia => new Provincia("macedonia", "Creada por las 4º guerra de Macedonia", new Formula(1, 1), new Formula(2, -1), new Formula(2, -2), new Formula(2, 2));
        public static Provincia CorcegaCerdenia => new Provincia("Córcega y Cerdeña", "Creada por 1º guerra púnica", new Formula(1, -5), new Formula(1, -1), new Formula(-1, 1), new Formula(-1, 1));
        public static Provincia Asia => new Provincia("Asia", "Creada por la conquista de Pérgamo", new Formula(1, 2), new Formula(1, 6), new Formula(2, -3), new Formula(2, 3));
        public static Provincia CretaCirene => new Provincia("Creta y Cirene", "Creada por conquista o segundos piratas cilicios", new Formula(1, -1), new Formula(1, 1), new Formula(1, -2), new Formula(1, 2));
        public static Provincia Siria => new Provincia("Siria", "Creada por 3º guerra mitridática", new Formula(1, -1), new Formula(1, 3), new Formula(1, 0), new Formula(1, 0));
        public static Provincia Africa => new Provincia("África", "Creada por 3º guerra púnica", new Formula(1, -1), new Formula(1, 3), new Formula(2, -4), new Formula(1, 1));

        public static IEnumerable<Provincia> GetAllProvincias()
        {
            return new List<Provincia>() {
                Sicilia, Iliria, GaliaCisalpina, GaliaNarbonense, CiliciaChipre,
                HispaniaCiterior, Bitinia, HispaniaUlterior, GaliaTransalpina, Macedonia,
                CorcegaCerdenia, Asia, CretaCirene, Siria, Africa };
        }
    }
}
