using System.Collections.Generic;

namespace Roma.Core.Model
{
    public class Guerra : IGuerra
    {
        public string Nombre { get; set; }
        public string Epoca { get; set; }
        public int FuerzaTerrestre { get; set; }
        public int FuerzaMaritima { get; set; }
        public int FlotasNecesarias { get; set; }
        public IEnumerable<int> Desastre { get; set; }
        public IEnumerable<int> Rechazo { get; set; }
        public int Botin { get; set; }
        public bool Sequia { get; set; }
        public EstadoGuerra Estado { get; set; }
        public int Numero { get; set; }
        public int NumeroTotal { get; set; }
        public List<Provincia> ProvinciasCreadas { get; set; }

        /// <summary>
        /// Si la creación de provincias requiere la derrota de todas las guerras de ese tipo
        /// </summary>
        public bool CreacionRequiereDerrotaTotal { get; set; }

        public TipoGuerra Tipo { get; private set; }

        public Guerra(TipoGuerra tipo, bool activa = false, bool sequia = false, bool derrotaTotal = false)
        {
            Tipo = tipo;
            Estado = activa ? EstadoGuerra.Activa : EstadoGuerra.Latente;
            Sequia = sequia;
            ProvinciasCreadas = new List<Provincia>();
            CreacionRequiereDerrotaTotal = derrotaTotal;
        }        
    }
}
