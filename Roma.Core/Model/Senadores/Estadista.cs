using System;

namespace Roma.Core.Model
{
    public class Estadista : Senador
    {
        public Senador Base { get; set; }
        public char Letra { get; set; }
        public Habilidad Habilidad { get; set; }
        public Estadista(int numero, char letra, string nombre, int militar, int oratoria, int lealtad, int influencia, Habilidad habilidad) : base(numero, nombre, militar, oratoria, lealtad, influencia)
        {
            Letra = letra;
            Habilidad = habilidad;
        }

        public void SobreSenador(Senador senadorBase)
        {
            if (senadorBase is null)
                throw new ArgumentNullException(nameof(senadorBase));

            Base = senadorBase;
            Numero = senadorBase.Numero;
            Militar = Math.Max(Militar, senadorBase.Militar);
            Oratoria = Math.Max(Oratoria, senadorBase.Militar);
            Lealtad = Math.Max(Lealtad, senadorBase.Militar);
            Influencia = Math.Max(Influencia, senadorBase.Influencia);
            Popularidad = Math.Max(0, senadorBase.Popularidad);
            Caballeros = senadorBase.Caballeros;
            JefeFaccion = senadorBase.JefeFaccion;
            Talentos = senadorBase.Talentos;
            EsCorrupto = senadorBase.EsCorrupto;
            EsMayor = senadorBase.EsMayor;
            EsConsular = senadorBase.EsMayor;
            Cargo = senadorBase.Cargo;
            Concesiones = senadorBase.Concesiones;
            Legiones = senadorBase.Legiones;
            Flotas = senadorBase.Flotas;
            LegionesLeales = senadorBase.LegionesLeales;
        }

        public override TipoSenador Tipo => TipoSenador.Estadista;

        public override string ToString() => $"Estadista {Nombre}";
        public override bool Equals(object obj)
        {
            if (obj != null && obj is Estadista e)
                return (e.Numero == Numero && e.Letra == Letra);
            return false;
        }
        public override int GetHashCode() => Numero.GetHashCode() * Letra.GetHashCode();
    }
}
