using System;

namespace Roma.Core.Model
{
    public class Formula
    {
        public int Dados { get; set; }
        public int Modificador { get; set; }

        public Formula(int dados, int modificador)
        {
            Dados = dados;
            Modificador = modificador;
        }

        public int Resultado()
        {
            if (Dados == 0) return Modificador;
            return (R.Instance.LanzarDados6(Math.Abs(Dados)) * (Dados > 0 ? 1 : -1)) + Modificador;
        }

        public override string ToString() => $"{Dados}d6{ModificadorText()}";

        private string ModificadorText()
        {
            if (Modificador == 0) return "";
            if (Modificador > 0) return $"+{Modificador}";
            return Modificador.ToString();
        }
    }
}
