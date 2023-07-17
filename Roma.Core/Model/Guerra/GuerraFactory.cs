using System.Collections.Generic;
using System.Linq;

namespace Roma.Core.Model
{
    public static class GuerraFactory
    {
        public static IEnumerable<IGuerra> GetAllGuerras => new List<IGuerra>() { PrimeraGuerraPunica, SegundaGuerraPunica, PrimeraGuerraIliria, SegundaGuerraIliria,
            PrimeraGuerraGalias, PrimeraGuerraMacedonia, SegundaGuerraMacedonia };
        public static IEnumerable<IGuerra> GetAllHeroes => new List<IGuerra>() { AntiocoIII, Hamilcar, Anibal, FilipoV };
        public static IEnumerable<IGuerra> GetAll => GetAllGuerras.Concat(GetAllHeroes);

        public static Heroe AntiocoIII => new Heroe("Antíoco III", "242 - 187 a. c.", 5, new int[] { 14 }, new int[] { 17 }, TipoGuerra.Siria);
        public static Heroe Hamilcar => new Heroe("Hamilcar", "275 - 229 a. c.", 3, new int[] { 8 }, new int[] { 12 }, TipoGuerra.Punica);
        public static Heroe Anibal => new Heroe("Anibal", "247 - 183 a. c.", 7, new int[] { 9 }, new int[] { 16 }, TipoGuerra.Punica);
        public static Heroe FilipoV => new Heroe("Filipo V", "238 - 179 a. c.", 6, new int[] { 15 }, new int[] { 14 }, TipoGuerra.Macedonia);

        public static Guerra PrimeraGuerraPunica => new Guerra(TipoGuerra.Punica)
        {
            Botin = 35,
            Desastre = new int[] { 13 },
            Epoca = "264 - 241 a.c.",
            FlotasNecesarias = 5,
            FuerzaMaritima = 10,
            FuerzaTerrestre = 10,
            Nombre = "1º guerra púnica",
            Numero = 1,
            NumeroTotal = 3,
            ProvinciasCreadas = new List<Provincia>() { ProvinciaFactory.CorcegaCerdenia, ProvinciaFactory.Sicilia },
            Rechazo = new int[] { 11, 14 }
        };

        public static Guerra SegundaGuerraPunica => new Guerra(TipoGuerra.Punica, activa:true)
        {
            Botin = 25,
            Desastre = new int[] { 10 },
            Epoca = "218 - 201 a.c.",
            FlotasNecesarias = 0,
            FuerzaMaritima = 5,
            FuerzaTerrestre = 15,
            Nombre = "2º guerra púnica",
            Numero = 2,
            NumeroTotal = 3,
            ProvinciasCreadas = new List<Provincia>() { ProvinciaFactory.HispaniaCiterior, ProvinciaFactory.HispaniaUlterior },
            Rechazo = new int[] { 11, 15 }
        };


        public static Guerra PrimeraGuerraIliria => new Guerra(TipoGuerra.Iliria, activa:false, sequia:true, derrotaTotal:true)
        {
            Botin = 10,
            Desastre = new int[] { 5 },
            Epoca = "229 - 228 a.c.",
            FlotasNecesarias = 0,
            FuerzaMaritima = 3,
            FuerzaTerrestre = 5,
            Nombre = "1º guerra iliria",
            Numero = 1,
            NumeroTotal = 2,
            ProvinciasCreadas = new List<Provincia>() { ProvinciaFactory.Iliria },
            Rechazo = new int[] { 17 }
        };

        public static Guerra SegundaGuerraIliria => new Guerra(TipoGuerra.Iliria, activa: true, sequia: false, derrotaTotal: true)
        {
            Botin = 10,
            Desastre = new int[] { 5 },
            Epoca = "220 - 219 a.c.",
            FlotasNecesarias = 0,
            FuerzaMaritima = 2,
            FuerzaTerrestre = 4,
            Nombre = "1º guerra iliria",
            Numero = 2,
            NumeroTotal = 2,
            ProvinciasCreadas = new List<Provincia>() { ProvinciaFactory.Iliria },
            Rechazo = new int[] { 17 }
        };

        public static Guerra GuerraSiria => new Guerra(TipoGuerra.Siria, activa: true)
        {
            Botin = 45,
            Desastre = new int[] { 16 },
            Epoca = "192 - 189 a.c.",
            FlotasNecesarias = 0,
            FuerzaMaritima = 2,
            FuerzaTerrestre = 6,
            Nombre = "Guerra de Siria",
            Numero = 1,
            NumeroTotal = 1,
            Rechazo = new int[] { 15 }
        };

        public static Guerra PrimeraGuerraGalias => new Guerra(TipoGuerra.Galia, activa: true)
        {
            Botin = 20,
            Desastre = new int[] { 13 },
            Epoca = "225 - 222 a.c.",
            FlotasNecesarias = 0,
            FuerzaMaritima = 0,
            FuerzaTerrestre = 10,
            Nombre = "1º guerra de las Galias",
            Numero = 1,
            NumeroTotal = 3,
            Rechazo = new int[] { 15 }
        };

        public static Guerra PrimeraGuerraMacedonia => new Guerra(TipoGuerra.Macedonia, activa: true)
        {
            Botin = 25,
            Desastre = new int[] { 12 },
            Epoca = "215 - 205 a.c.",
            FlotasNecesarias = 0,
            FuerzaMaritima = 10,
            FuerzaTerrestre = 12,
            Nombre = "1º guerra de Macedonia",
            Numero = 1,
            NumeroTotal = 4,
            Rechazo = new int[] { 11, 18 }
        };

        public static Guerra SegundaGuerraMacedonia => new Guerra(TipoGuerra.Macedonia, activa: true)
        {
            Botin = 45,
            Desastre = new int[] { 13 },
            Epoca = "200 - 196 a.c.",
            FlotasNecesarias = 0,
            FuerzaMaritima = 5,
            FuerzaTerrestre = 10,
            Nombre = "2º guerra de Macedonia",
            Numero = 2,
            NumeroTotal = 4,
            Rechazo = new int[] { 14 }
        };
    }
}
