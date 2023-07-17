using System.Collections.Generic;

namespace Roma.Core.Model
{
    public interface ISenador
    {
        /// <summary>
        /// +1 talento por turno, +1 voto
        /// </summary>
        int Caballeros { get; set; }

        int Influencia { get; set; }
        int Lealtad { get; set; }
        int Militar { get; set; }
        string Nombre { get; set; }
        int Numero { get; set; }
        int Oratoria { get; set; }
        int Popularidad { get; set; }
        bool JefeFaccion { get; set; }
        int Talentos { get; set; }

        /// <summary>
        /// Para atraer senadores a la facción
        /// </summary>
        int PoderInfluencia { get; }

        /// <summary>
        /// Votos en el senado
        /// </summary>
        int Votos { get; }

        /// <summary>
        /// Ingresos obtenidos en fase de ingresos
        /// </summary>
        IEnumerable<(string descripcion, int talentos)> Ingresos { get; }
        int TotalIngresos { get; }

        /// <summary>
        /// Tipo de senador (Senador / Estadista)
        /// </summary>
        TipoSenador Tipo { get; }

        /// <summary>
        /// Indica si el senador es corrupto y puede ser objetivo de un juicio menor
        /// </summary>
        bool EsCorrupto { get; set; }

        /// <summary>
        /// Indica si el senador ha ostentado un cargo y puede ser objetivo de un juicio mayor
        /// </summary>
        bool EsMayor { get; set; }

        /// <summary>
        /// Indica si el senador puede ser elegible como consul
        /// </summary>
        bool EsConsular { get; set; }

        /// <summary>
        /// Cargo que ostenta el senador
        /// </summary>
        Cargo Cargo { get; set; }

        List<Legion> Legiones {get; set; }
        List<Flota> Flotas { get; set; }

        List<int> LegionesLeales { get; set; }
    }
}