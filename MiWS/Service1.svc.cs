using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MiWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        List<BusCarac> listaBus = new List<BusCarac>();
        public BusCarac enviar(BusCarac ObusCarac)
        {
            listaBus.Add(ObusCarac);
            return ObusCarac;
        }

        public List<BusCarac> recibir()
        {
            return listaBus;
        }

        List<Ruta> listaRuta = new List<Ruta>();
        public Ruta enviarR(Ruta RutaCarac)
        {
            listaRuta.Add(RutaCarac);
            return RutaCarac;
        }

 
    }
}
