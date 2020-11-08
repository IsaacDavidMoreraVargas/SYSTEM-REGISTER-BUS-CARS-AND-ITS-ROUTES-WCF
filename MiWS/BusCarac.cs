using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MiWS
{

    [DataContract()]
    public class BusCarac
    {
        [DataMember]
        String provincia { set; get;}
        [DataMember]
        String ruta { set; get; }
        [DataMember]
        String Inscrito { set; get; }
        [DataMember]
        String Autorizado { set; get; }
        [DataMember]
        String PersonasPie { set; get; }
        [DataMember]
        String PersonasSentadas { set; get; }

    }
}