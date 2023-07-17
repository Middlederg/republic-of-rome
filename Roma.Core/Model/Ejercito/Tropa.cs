namespace Roma.Core.Model
{
    public abstract class Tropa : ITropa
    {
        public int Numero { get; private set; }
        public virtual int Fuerza => 1;
        public int CostoBase => 10;

        public Tropa(int numero)
        {
            Numero = numero;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == GetType())
                return ((obj is ITropa t) && t.Numero == Numero);
            return false;
        }
        public override int GetHashCode() => Numero.GetHashCode();
    }
}
