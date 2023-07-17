using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roma.Core.Model
{
    public class Senador : ISenador
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }

        [Description("Pericia como General terrestre y naval")]
        public int Militar { get; set; }

        [Description("Destreza política y capacidad para atraer votos")]
        public int Oratoria { get; set; }

        [Description("Grado de compromiso que tiene el Senador con la facción")]
        public int Lealtad { get; set; }

        private int influencia;
        public int Influencia
        {
            get => influencia;
            set => influencia = Math.Max(0, value);
        }

        private int popularidad;
        public int Popularidad
        {
            get => popularidad;
            set
            {
                if (value > 9) popularidad = 9;
                if (value < -9) popularidad = -9;
            }
        }

        public int Caballeros { get; set; }

        public virtual TipoSenador Tipo => TipoSenador.Basico;

        public bool EsCorrupto { get; set; }
        public bool EsMayor { get; set; }
        public bool EsConsular { get; set; }
        public Cargo Cargo { get; set; }
        public List<Concesion> Concesiones { get; set; }
        public List<Legion> Legiones { get; set; }
        public List<Flota> Flotas { get; set; }
        public List<int> LegionesLeales { get; set; }

        public bool JefeFaccion { get; set; }
        public int Talentos { get; set; }

        /// <summary>
        /// Senador básico
        /// </summary>
        /// <param name="numero">Número del senador</param>
        /// <param name="nombre">Nombre del snador</param>
        /// <param name="militar">Poder militar</param>
        /// <param name="oratoria">Poder de oratoria</param>
        /// <param name="lealtad">Lealtad</param>
        /// <param name="influencia">Influencia del senador</param>
        public Senador(int numero, string nombre, int militar, int oratoria, int lealtad, int influencia)
        {
            Numero = numero;
            Nombre = nombre;
            Militar = militar;
            Oratoria = oratoria;
            Lealtad = lealtad;
            this.influencia = influencia;
            popularidad = 0;
            Caballeros = 0;
            JefeFaccion = false;
            Talentos = 0;
        }

        public int PoderInfluencia => influencia + Oratoria;
        public int Votos => Oratoria + Caballeros;
        public IEnumerable<(string descripcion, int talentos)> Ingresos
        {
            get
            {
                yield return (JefeFaccion) ? ("Jefe de facción", 3) : ("Ingreso básico", 1);
                if (Caballeros > 0) yield return ($"{Caballeros} caballeros", Caballeros);
                var concesiones = Concesiones.Where(x => x.Momento.Equals(MomentoActivacion.FaseIngresos));
                if (concesiones.Any()) yield return ($"{concesiones.Count()} concesi{(concesiones.Count() > 1 ? "ones" : "ón")}", concesiones.Sum(c => c.Talentos));
            }
        }
        public int TotalIngresos => Ingresos.Sum(x => x.talentos);

        

        public override string ToString() => $"Senador {Nombre}";
        public override bool Equals(object obj)
        {
            if (obj != null && obj is Estadista e)
                return false;
            return ((Senador)obj).Numero == Numero;
        }
        public override int GetHashCode() => Numero.GetHashCode();
    }
}
