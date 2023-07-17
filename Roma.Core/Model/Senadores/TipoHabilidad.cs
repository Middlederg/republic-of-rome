using System.ComponentModel;

namespace Roma.Core.Model
{
    public enum TipoHabilidad
    {
        [Description("Anula efecto de rechazo o desastre")]
        AnulaRechazoDesastre,

        [Description("Reduce a la mitad la perdida de legiones o tropas en comate")]
        MitadPerdidasEnCombate,

        [Description("+1 tribuno extra por turno")]
        TribunoPorTurno
    }



}
