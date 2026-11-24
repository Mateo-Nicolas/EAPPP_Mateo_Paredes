using System.ComponentModel;
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
            this.Load += frmPedidoCafeteria_Load;
            lvPedido.SelectedIndexChanged += lvPedido_SelectedIndexChanged;
            txtCantidad.Validating += txtCantidad_Validating;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtProducto.TextChanged += txtProducto_TextChanged;
            rbtnEntrega.CheckedChanged += rbtnEntrega_CheckedChanged;
            chkPostre.CheckedChanged += chkPostre_CheckedChanged;
            chkServilletas.CheckedChanged += chkServilletas_CheckedChanged;
            btnAgregar.Click += btnAgregar_Click;
            btnQuitar.Click += btnQuitar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

        }




        private void frmPedidoCafeteria_Load(object sender, EventArgs e)
        {

            lvCatalogo.View = View.Details;
            lvCatalogo.FullRowSelect = true;
            lvCatalogo.Columns.Clear();
            lvCatalogo.Columns.Add("Producto", 150);
            lvCatalogo.Columns.Add("Precio", 80);

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
                ("Botella de agua", 0.75m)
            };

            foreach (var producto in productos)
            {
                ListViewItem fila = new ListViewItem(producto.Nombre);

                fila.SubItems.Add(producto.Precio.ToString("C2"));

                fila.Tag = producto.Precio;

                lvCatalogo.Items.Add(fila);
            }

            lvPedido.View = View.Details;
            lvPedido.FullRowSelect = true;

            lvPedido.Columns.Clear();
            lvPedido.Columns.Add("Producto", 110);
            lvPedido.Columns.Add("Cant.", 45);
            lvPedido.Columns.Add("Subtotal", 75);

            txtProducto.ReadOnly = true;
            txtCantidad.Text = "1";

            rbtnMostrador.Checked = true;
            rbtnEntrega.Checked = false;

            chkPostre.Checked = false;
            chkServilletas.Checked = false;

            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Seleccione un producto.";

        }
        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvCatalogo.SelectedItems.Count > 0)
            {
                ListViewItem productoSeleccionado = lvCatalogo.SelectedItems[0];

                txtProducto.Text = productoSeleccionado.Text;

                decimal precio = (decimal)productoSeleccionado.Tag;

                int cantidad;

                bool cantidadValida = int.TryParse(txtCantidad.Text, out cantidad)
                                      && cantidad >= 1;

                btnAgregar.Enabled = cantidadValida;

                lblEstado.Text = "Estado: Producto seleccionado: "
                                 + productoSeleccionado.Text
                                 + " (" + precio.ToString("C2") + ").";
            }
            else
            {
                txtProducto.Clear();
                btnAgregar.Enabled = false;
            }
        }

        private void lvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count > 0)
            {
                btnQuitar.Enabled = true;
            }
            else
            {
                btnQuitar.Enabled = false;
            }
        }


        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad < 1)
            {
                e.Cancel = true;

                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual a 1.";

                txtCantidad.SelectAll();
            }
        }

        private void ValidarDatosAgregar()
        {
            bool productoValido = !string.IsNullOrWhiteSpace(txtProducto.Text);

            int cantidad;

            bool cantidadValida = int.TryParse(txtCantidad.Text, out cantidad)
                                  && cantidad >= 1;

            btnAgregar.Enabled = productoValido && cantidadValida;
        }


        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ValidarDatosAgregar();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            ValidarDatosAgregar();
        }

        private void ActualizarTotal()
        {
            decimal total = 0;

            foreach (ListViewItem item in lvPedido.Items)
            {
                if (item.Tag is decimal subtotal)
                {
                    total += subtotal;
                }
            }

            if (rbtnEntrega.Checked)
            {
                total += 0.50m;
            }

            if (chkPostre.Checked)
            {
                total += 1.00m;
            }

            lblTotal.Text = "Total: $" + total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }


        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();

            if (rbtnEntrega.Checked)
            {
                lblEstado.Text = "Opción aplicada: Entrega en aula (+$0.50).";
            }
            else
            {
                lblEstado.Text = "Opción aplicada: Retiro en mostrador.";
            }
        }



        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();

            if (chkPostre.Checked)
            {
                lblEstado.Text = "Opción aplicada: Postre del día (+$1.00).";
            }
            else
            {
                lblEstado.Text = "Opción quitada: Postre del día.";
            }
        }


        private void chkServilletas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();

            if (chkServilletas.Checked)
            {
                lblEstado.Text = "Opción aplicada: Servilletas / Cubiertos (+$0.00).";
            }
            else
            {
                lblEstado.Text = "Opción quitada: Servilletas / Cubiertos.";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                lblEstado.Text = "Error: Ingrese el nombre del cliente.";
                txtCliente.Focus();
                return;
            }

            if (lvCatalogo.SelectedItems.Count == 0)
            {
                lblEstado.Text = "Error: Seleccione un producto.";
                return;
            }

            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad < 1)
            {
                lblEstado.Text = "Error: Ingrese una cantidad válida.";
                txtCantidad.Focus();
                return;
            }

            ListViewItem productoSeleccionado = lvCatalogo.SelectedItems[0];

            string nombre = productoSeleccionado.Text;
            decimal precio = (decimal)productoSeleccionado.Tag;

            decimal subtotal = precio * cantidad;

            ListViewItem fila = new ListViewItem(nombre);
            fila.SubItems.Add(cantidad.ToString());
            fila.SubItems.Add("$" + subtotal.ToString("F2",
                System.Globalization.CultureInfo.InvariantCulture));

            fila.Tag = subtotal;

            lvPedido.Items.Add(fila);

            ActualizarTotal();

            lblEstado.Text = "Producto agregado correctamente.";

            txtCantidad.Text = "1";
        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count > 0)
            {
                lvPedido.Items.Remove(lvPedido.SelectedItems[0]);

                ActualizarTotal();

                lblEstado.Text = "Producto eliminado del pedido.";

                btnQuitar.Enabled = false;
            }
            else
            {
                lblEstado.Text = "Seleccione un producto para eliminar.";
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Text = "1";

            lvPedido.Items.Clear();

            lvCatalogo.SelectedItems.Clear();

            rbtnMostrador.Checked = true;
            rbtnEntrega.Checked = false;

            chkPostre.Checked = false;
            chkServilletas.Checked = false;

            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            ActualizarTotal();

            lblEstado.Text = "Pedido limpiado correctamente.";
        }


    }
}

