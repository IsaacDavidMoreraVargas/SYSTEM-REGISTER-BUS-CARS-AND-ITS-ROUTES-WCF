using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.archivos
{
    public partial class agregaRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string provincia = "";
        string inicioR = "";
        string finR = "";
        string rural = "";
        int kilometros = 0;


        protected void ButtonRegistra_Click(object sender, EventArgs e)
        {
            bool completado = true;
            string negativo="";

            if (DropProvincia.Text == "---")
            {
                completado = false;
                negativo += "\n-Provincia vacio";

            }
            else
            {
                provincia = DropProvincia.Text;

            }


            if (TextInicio.Text == " ")
            {
                completado = false;
                negativo += "\n-Punto inicio vacio";
            }
            else
            {
                inicioR = TextInicio.Text;

            }

            if (TextInicio.Text.Length <= 0)
            {
                completado = false;
                negativo += "\n-Punto inicio vacio";
            }
            else
            {
                inicioR = TextInicio.Text;

            }

            if (TextFin.Text == " ")
            {
                completado = false;
                negativo += "\n-Punto fin vacio";
            }
            else
            {
                finR = TextFin.Text;

            }

            if (TextFin.Text.Length <= 0)
            {
                completado = false;
                negativo += "\n-Punto fin vacio";
            }
            else
            {
                finR = TextFin.Text;

            }

            if (DropRural.Text == "---")
            {
                completado = false;
                negativo += "\n-Rural vacio";
            }
            else
            {
                rural = DropRural.Text;

            }

            try
            {
                kilometros = Convert.ToInt32(TextKilometros.Text);
            }
            catch (Exception) { completado = false; negativo += "\n-Kilometros vacio o no es numero"; }


            if (completado == true)
            {
                string mensaje1 = "\nProvincia:" + provincia + "\nInicio ruta: " + inicioR + "\nFin ruta: " + finR + "\nRural: " + rural + "\nCantidad kilometros en ruta: " + kilometros + "*";
                string guardar = provincia + "," + inicioR + "," + finR + "," + rural + "," + kilometros + "*";
                TextInicio.Text = "";
                TextFin.Text = "";
                DropProvincia.Text = "---";
                DropRural.Text = "---";
                TextKilometros.Text = "";
                Session["ruta"] += guardar;
                mensaje1 = mensaje1.Remove(mensaje1.Length - 1);
                TextMostrar.Text = "Ruta agregada: \n" + mensaje1;
            }
            else
            {

                TextMostrar.Text = "Existe algun dato erroneo, no se guardara \n\n\nProblemas presentes: " + negativo;
            }

            using (WDService.Service1Client Ruta = new WDService.Service1Client())
            {
                /*
               Ruta.enviar(BusCarac);
               */
            }

        }
    }
}