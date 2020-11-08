using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MiWS
{
    [DataContract()]

    public class Ruta
    {
        [DataMember]
        String provincia { set; get; }
        [DataMember]
        String puntoInicio{ set; get; }
        [DataMember]
        String PuntoFin { set; get; }
        [DataMember]
        String CantKm { set; get; }
        [DataMember]
        String Rural { set; get; }

    }
}