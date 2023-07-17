using System.ComponentModel;

namespace Roma.Core.Model
{
    [Description("Legión")]
    public class Legion : Tropa
    {
        public bool EsLeal { get; set; }
        public override int Fuerza => EsLeal ? 2 : 1;

        public Legion(int numero) : base(numero)
        {
            EsLeal = false;
        }

        public override string ToString() => $"Legión {Numero}";
    }
}
