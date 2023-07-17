using System.Collections.Generic;
using System;

namespace Roma.Core.Model
{
    public abstract class Concesion : IConcesion, ICarta
    {
        public int Id { get; }
        public string Titulo { get; }
        public int Talentos { get; private set; }
        public MomentoActivacion Momento { get; protected set; }
        public bool Utilizada { get; set; }
        public string Nombre => Titulo;
        public string Descripcion => $"Concesión : {Titulo}";
        public abstract int NumCartas { get; }

        public Concesion(int id, string titulo, int talentos, MomentoActivacion momento)
        {
            Id = id;
            Titulo = titulo;
            Talentos = talentos;
            Utilizada = false;
            Momento = momento;
        }

        public override string ToString() => Titulo;
        public override bool Equals(object obj)
        {
            if (obj != null && obj is Concesion c)
                return (c.Id == Id);
            return false;
        }
        public override int GetHashCode() => Id.GetHashCode();

        public virtual (int talentos, int popularidad) Cobrar(MomentoActivacion momento, int multiplicador = 1, bool explotar = false, NivelSequia sequia = NivelSequia.SinSequia)
        {
            if (!momento.Equals(Momento)) throw new Exception($"Solo se puede activar la concesión en {Momento.ToString()}");
            if (explotar) throw new Exception("No se puede explotar la concesión");
            Utilizada = true;
            return (Talentos * multiplicador, 0);
        }

        public virtual bool Destruida(IEnumerable<IGuerra> guerrasActivas = null) => false;
        public virtual bool Destruible() => true;
        public virtual bool DestruiblePorDesastreNatrual() => false;
        public virtual bool RequisadaPorLandBill() => false;

        public void RealizarAccion()
        {
            throw new NotImplementedException();
        }
    }
}
