using System.ComponentModel;

namespace Roma.Core.Model
{
    [Description("Flota")]
    public class Flota : Tropa
    {
        public Flota(int numero) : base(numero) { }       
        public override string ToString() => $"Flota {Numero}";
    }
}
