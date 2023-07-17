using System.Collections.Generic;

namespace Roma.Core.Model
{
    public static class SenadorFactory
    {
        public static Senador Cornelio => new Senador(1, "Cornelio", 4, 3, 9, 5);
        public static Senador Fabio => new Senador(2, "Fabio", 4, 2, 9, 5);
        public static Senador Valerio => new Senador(3, "Valerio", 1, 2, 10, 5);
        public static Senador Julio => new Senador(4, "Julio", 4, 3, 9, 4);
        public static Senador Claudio => new Senador(5, "Claudio", 2, 3, 7, 4);
        public static Senador Manlio => new Senador(6, "Manlio", 3, 2, 7, 4);
        public static Senador Fulvio => new Senador(7, "Fulvio", 2, 2, 8, 4);
        public static Senador Furio => new Senador(8, "Furio", 3, 3, 8, 3);
        public static Senador Aurelio => new Senador(9, "Aurelio", 2, 3, 7, 3);
        public static Senador Junio => new Senador(10, "Junio", 1, 2, 8, 3);
        public static Senador Papirio => new Senador(11, "Papirio", 1, 2, 6, 3);
        public static Senador Agilio => new Senador(12, "Agilio", 2, 2, 7, 3);
        public static Senador Flaminio => new Senador(13, "Flaminio", 4, 2, 6, 3);
        public static Senador Elio => new Senador(14, "Elio", 3, 4, 7, 2);
        public static Senador Sulpicio => new Senador(15, "Sulpicio", 3, 2, 8, 2);
        public static Senador Calpurnio => new Senador(16, "Calpurnio", 1, 2, 9, 2);
        public static Senador Plautio => new Senador(17, "Plautio", 2, 1, 6, 2);
        public static Senador Quinto => new Senador(18, "Quinto", 3, 2, 6, 1);
        public static Senador Emilio => new Senador(19, "Emilio", 4, 2, 8, 1);
        public static Senador Terencio => new Senador(20, "Terencio", 2, 1, 6, 1);

        public static IEnumerable<ISenador> GetAllBasicos()
        {
            return new List<Senador>() {
                Cornelio, Fabio, Valerio, Julio, Claudio,
                Manlio, Fulvio, Furio, Aurelio, Junio,
                Papirio, Agilio, Flaminio, Elio, Sulpicio,
                Calpurnio, Plautio, Quinto, Emilio, Terencio };
        }

        public static Estadista Escipion => new Estadista(1, 'A', "P. Cornelio Escipión El Africano", 5, 5, 7, 6, new Habilidad(TipoHabilidad.AnulaRechazoDesastre, TipoGuerra.Punica));
        public static Estadista Caton => new Estadista(22, 'B', "M. Porcio Catón El Viejo", 1, 6, 10, 1, new Habilidad(TipoHabilidad.TribunoPorTurno));
        public static Estadista QuintoFabioMaximo => new Estadista(2, 'A', "Q. Fabio Máximo Verrucoso Cuncator", 5, 2, 7, 3, new Habilidad(TipoHabilidad.MitadPerdidasEnCombate));
        public static Estadista TitoQuincioFlaminino => new Estadista(18, 'A', "T. Quincio Flaminino", 5, 4, 7, 4, new Habilidad(TipoHabilidad.AnulaRechazoDesastre, TipoGuerra.Macedonia));
        public static Estadista EmilioPauloMacedonio => new Estadista(19, 'A', "L. Emilio Paulo Macedonio", 5, 4, 8, 4, new Habilidad(TipoHabilidad.AnulaRechazoDesastre, TipoGuerra.Macedonia));

        public static IEnumerable<ISenador> GetAllEstadistas() => new List<Senador>() { Escipion, Caton, QuintoFabioMaximo, TitoQuincioFlaminino, EmilioPauloMacedonio };
        
    }
}
