using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.archivos
{
    public partial class listado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
           if ((string)Session["bus"] != null)
           {
            
               TextMostrar.Text = Convert.ToString(Session["bus"]) ;

                String comodin = Convert.ToString(Session["bus"]);
                String comodin2 = "\nProvincia: "+DropProvinicia.Text;
                string comodin3 = "";
                int final = 0;

                for(int i=0;i<comodin.Length; i++)
                {
                    if (comodin3==comodin2)
                    {

                        while (comodin[i] != '*')
                        {

                            comodin3 += comodin[i];
                            i++;
                        }

                        comodin3 = comodin3.Remove(comodin3.Length - 1);
                        comodin3= comodin3.Replace(',', '\n');

                        TextMostrar.Text +="\n"+ comodin3;
                        comodin3 = "";
                    }
                    else
                    {
                        comodin3 += comodin[i];

                    }

                }
    
            }
            else
            {

                TextMostrar.Text += "No existe ningun bus en la base de datos";
            }
  
            using (WDService.Service1Client BusCarac = new WDService.Service1Client())
            {

                //TextMostrar.Text = BusCarac.recibir().ToString();
            }

        }
    }
}