using System.Drawing.Drawing2D;
using System.Numerics;
using System.Xml.Linq;
using Microsoft.VisualBasic.Devices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EAPPP_Mateo_Paredes
{


    public partial class frmPedidoCafeteria : Form
    {
        public frmPedidoCafeteria()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void frmPedidoCafeteria_Load(object sender, EventArgs e)
        {
            

        }

        


        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            







            lvCatalogo.Items.Clear();
            var productos = new (string Nombre, decimal Precio)[]
            {
             ("Empanada de queso", 1.25m),
             ("Sánduche de pollo", 2.50m),
             ("Bolón de verde mixto", 2.25m),
             ("Humita tradicional", 1.50m),
             ("Tostada con queso", 1.00m),
             ("Café pasado", 0.85m),
             ("Chocolate caliente", 1.35m),
             ("Jugo natural (naranja/mora)", 1.50m),
             ("Batido de fruta", 2.00m),
             ("Botella de agua", 0.75m),
            };
        }
    }


       

}

