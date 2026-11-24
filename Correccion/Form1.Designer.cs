namespace EAPPP_Mateo_Paredes
{
    partial class frmPedidoCafeteria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lvCatalogo = new ListView();
            label2 = new Label();
            label3 = new Label();
            txtCliente = new TextBox();
            label4 = new Label();
            txtProducto = new TextBox();
            label5 = new Label();
            txtCantidad = new TextBox();
            groupBox1 = new GroupBox();
            rbtnEntrega = new RadioButton();
            rbtnMostrador = new RadioButton();
            groupBox2 = new GroupBox();
            chkServilletas = new CheckBox();
            chkPostre = new CheckBox();
            label6 = new Label();
            lvPedido = new ListView();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            lblTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(576, 25);
            label1.TabIndex = 0;
            label1.Text = "Gestor Rapido de pedidos con catalogo - Cafeteria Universitaria";
            // 
            // lvCatalogo
            // 
            lvCatalogo.Location = new Point(12, 96);
            lvCatalogo.Name = "lvCatalogo";
            lvCatalogo.Size = new Size(204, 285);
            lvCatalogo.TabIndex = 1;
            lvCatalogo.UseCompatibleStateImageBehavior = false;
            lvCatalogo.View = View.Details;
            lvCatalogo.SelectedIndexChanged += lvCatalogo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 2;
            label2.Text = "Catalogo de Productos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 75);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Cliente: ";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(283, 75);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(254, 23);
            txtCliente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 107);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 5;
            label4.Text = "Producto: ";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(283, 104);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(114, 23);
            txtProducto.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 107);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 7;
            label5.Text = "Cant: ";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(437, 104);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnEntrega);
            groupBox1.Controls.Add(rbtnMostrador);
            groupBox1.Location = new Point(232, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 64);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modalidad de Atención";
           
            // 
            // rbtnEntrega
            // 
            rbtnEntrega.AutoSize = true;
            rbtnEntrega.Location = new Point(147, 29);
            rbtnEntrega.Name = "rbtnEntrega";
            rbtnEntrega.Size = new Size(152, 19);
            rbtnEntrega.TabIndex = 1;
            rbtnEntrega.TabStop = true;
            rbtnEntrega.Text = "Entrega en aula (+$0.50)";
            rbtnEntrega.UseVisualStyleBackColor = true;
            // 
            // rbtnMostrador
            // 
            rbtnMostrador.AutoSize = true;
            rbtnMostrador.Location = new Point(11, 29);
            rbtnMostrador.Name = "rbtnMostrador";
            rbtnMostrador.Size = new Size(130, 19);
            rbtnMostrador.TabIndex = 0;
            rbtnMostrador.TabStop = true;
            rbtnMostrador.Text = "Retiro en mostrador";
            rbtnMostrador.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkServilletas);
            groupBox2.Controls.Add(chkPostre);
            groupBox2.Location = new Point(235, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 66);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Extras del Pedido";
            // 
            // chkServilletas
            // 
            chkServilletas.AutoSize = true;
            chkServilletas.Location = new Point(156, 29);
            chkServilletas.Name = "chkServilletas";
            chkServilletas.Size = new Size(140, 19);
            chkServilletas.TabIndex = 1;
            chkServilletas.Text = "Servilletas / Cubiertos";
            chkServilletas.UseVisualStyleBackColor = true;
           
            // 
            // chkPostre
            // 
            chkPostre.AutoSize = true;
            chkPostre.Location = new Point(7, 29);
            chkPostre.Name = "chkPostre";
            chkPostre.Size = new Size(143, 19);
            chkPostre.TabIndex = 0;
            chkPostre.Text = "Postre del día (+$1.00)";
            chkPostre.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(566, 74);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 11;
            label6.Text = "Detalles del Pedido";
            // 
            // lvPedido
            // 
            lvPedido.Location = new Point(558, 104);
            lvPedido.Name = "lvPedido";
            lvPedido.Size = new Size(220, 285);
            lvPedido.TabIndex = 12;
            lvPedido.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PaleGreen;
            btnAgregar.Location = new Point(235, 305);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar Ítem";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.IndianRed;
            btnQuitar.Location = new Point(326, 305);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(123, 23);
            btnQuitar.TabIndex = 14;
            btnQuitar.Text = "Quitar Seleccionado";
            btnQuitar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(455, 305);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(22, 425);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(176, 15);
            lblEstado.TabIndex = 16;
            lblEstado.Text = "Estado: Seleccione un producto.";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.Control;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.LimeGreen;
            lblTotal.Location = new Point(686, 392);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 20);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Total: $0.00";
            // 
            // frmPedidoCafeteria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblEstado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(lvPedido);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtCantidad);
            Controls.Add(label5);
            Controls.Add(txtProducto);
            Controls.Add(label4);
            Controls.Add(txtCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lvCatalogo);
            Controls.Add(label1);
            Name = "frmPedidoCafeteria";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvCatalogo;
        private Label label2;
        private Label label3;
        private TextBox txtCliente;
        private Label label4;
        private TextBox txtProducto;
        private Label label5;
        private TextBox txtCantidad;
        private GroupBox groupBox1;
        private RadioButton rbtnMostrador;
        private RadioButton rbtnEntrega;
        private GroupBox groupBox2;
        private CheckBox chkServilletas;
        private CheckBox chkPostre;
        private Label label6;
        private ListView lvPedido;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnLimpiar;
        private Label lblEstado;
        private Label lblTotal;
    }
}
