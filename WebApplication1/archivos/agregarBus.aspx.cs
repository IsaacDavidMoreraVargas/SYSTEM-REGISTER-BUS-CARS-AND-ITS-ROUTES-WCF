using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.archivos
{
    public partial class agregarBus : System.Web.UI.Page
    {
        int pasajerosPie=0;
        int pasajeroSentados = 0;
        string ruta =" ";
        
        string provincia = " " ;
        string inscrito = " ";
        string autorizado = " ";
          

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegistra_Click(object sender, EventArgs e)
        {
            Boolean correcto = true;
            string negativo = "";


            if (DropProvincia.Text == "---")
            {
                correcto = false;
                negativo += "\n - Provincia vacio";
            }
            else
            {
                provincia = DropProvincia.Text;

            }

            if (TextRuta.Text.Length > 7)
            {
                negativo += "\n-Ruta mayor a 7 digitos";
                correcto = false;
            }
            else
            {
                ruta = TextRuta.Text;
            }

            if (TextRuta.Text.Length <= 0)
            {
                negativo += "\n-Ruta vacio";
                correcto = false;
            }
            else
            {
                ruta = TextRuta.Text;
            }

            if (TextRuta.Text==" ")
            {
                negativo += "\n-Ruta vacio";
                correcto = false;
            }
            else
            {
                ruta = TextRuta.Text;
            }


            if (DropInscrito.Text == "---")
            {
                    correcto = false;
                    negativo += "\n - Inscrito vacio";
            }
            else
            {
                    inscrito = DropInscrito.Text;

            }

            if (DropAutorizado.Text == "---")
            {
                correcto = false;
                negativo += "\n - Autorizado Vacio ";
            }
            else
            {
                autorizado = DropAutorizado.Text;
            }

            try
            {
                pasajeroSentados = Convert.ToInt32(TextPaSentados.Text);

            }
            catch (Exception) { correcto = false; negativo += "\n - Cantidad pasajeros sentados vacio o no es numero"; };


            try
            {
                pasajerosPie = Convert.ToInt32(TextPaPie.Text);

            }
            catch (Exception) { correcto = false; negativo += "\n - Cantidad pasajeros pie vacio o no es numero "; };

            if (correcto == true)
            {
                    string mensaje1 = "\nProvincia: " + provincia + "\nRuta: " + ruta + "\nInscrito: " + inscrito + "\nAutorizado: " + autorizado + "\nCantidad pasajeros en pie: " + pasajerosPie + "\nCantidad pasajeros sentados: " + pasajeroSentados+"*";
                    string guardar= provincia + "," + ruta + "," + inscrito + "," + autorizado + "," + pasajerosPie + "," + pasajeroSentados + "*";
                    Session["bus"] += mensaje1;
                    TextRuta.Text = "";
                    TextPaSentados.Text = "";
                    TextPaPie.Text = "";
                    DropProvincia.Text = "---";
                    DropInscrito.Text = "---";
                    DropAutorizado.Text = "---";

                using (WDService.Service1Client BusCarac = new WDService.Service1Client())
                {
                       
                    //BusCarac.enviar(BusCarac);
                }
                    mensaje1 = mensaje1.Remove(mensaje1.Length - 1);
                    TextMostrar.Text = "Bus agregado: \n" + mensaje1;
            }
            else
            {

                TextMostrar.Text = "Existe algun dato erroneo, no se guardara \n\n\nProblemas presentes: "+negativo;
            }

        }
    }
}