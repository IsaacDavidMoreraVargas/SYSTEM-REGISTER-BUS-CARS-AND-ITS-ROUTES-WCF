using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MiWS
{
   
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        BusCarac enviar(BusCarac ObusCarac);
        [OperationContract]
        List<BusCarac> recibir();
        [OperationContract]
        Ruta enviarR(Ruta RutaCarac);
    }
}
