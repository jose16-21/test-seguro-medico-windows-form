namespace WindowsFormsApp
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.DescripcionSer = new System.Windows.Forms.TextBox();
            this.NombreSer = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.DireccionPrvo = new System.Windows.Forms.TextBox();
            this.RazonProv = new System.Windows.Forms.TextBox();
            this.NombreProv = new System.Windows.Forms.TextBox();
            this.DropProveedores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnPersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnServicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // Nombres
            // 
            this.Nombres.Location = new System.Drawing.Point(48, 84);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(125, 27);
            this.Nombres.TabIndex = 1;
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(214, 84);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(125, 27);
            this.Apellidos.TabIndex = 1;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(370, 88);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(125, 27);
            this.Direccion.TabIndex = 1;
            // 
            // DescripcionSer
            // 
            this.DescripcionSer.Location = new System.Drawing.Point(193, 416);
            this.DescripcionSer.Name = "DescripcionSer";
            this.DescripcionSer.Size = new System.Drawing.Size(125, 27);
            this.DescripcionSer.TabIndex = 1;
            // 
            // NombreSer
            // 
            this.NombreSer.Location = new System.Drawing.Point(48, 416);
            this.NombreSer.Name = "NombreSer";
            this.NombreSer.Size = new System.Drawing.Size(125, 27);
            this.NombreSer.TabIndex = 1;
            // 
            // Edad
            // 
            this.Edad.Location = new System.Drawing.Point(537, 88);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(46, 27);
            this.Edad.TabIndex = 1;
            // 
            // DireccionPrvo
            // 
            this.DireccionPrvo.Location = new System.Drawing.Point(342, 259);
            this.DireccionPrvo.Name = "DireccionPrvo";
            this.DireccionPrvo.Size = new System.Drawing.Size(125, 27);
            this.DireccionPrvo.TabIndex = 1;
            // 
            // RazonProv
            // 
            this.RazonProv.Location = new System.Drawing.Point(193, 259);
            this.RazonProv.Name = "RazonProv";
            this.RazonProv.Size = new System.Drawing.Size(125, 27);
            this.RazonProv.TabIndex = 1;
            // 
            // NombreProv
            // 
            this.NombreProv.Location = new System.Drawing.Point(48, 259);
            this.NombreProv.Name = "NombreProv";
            this.NombreProv.Size = new System.Drawing.Size(125, 27);
            this.NombreProv.TabIndex = 1;
            // 
            // DropProveedores
            // 
            this.DropProveedores.FormattingEnabled = true;
            this.DropProveedores.Location = new System.Drawing.Point(342, 416);
            this.DropProveedores.Name = "DropProveedores";
            this.DropProveedores.Size = new System.Drawing.Size(151, 28);
            this.DropProveedores.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edad";
            // 
            // BtnPersona
            // 
            this.BtnPersona.Location = new System.Drawing.Point(48, 142);
            this.BtnPersona.Name = "BtnPersona";
            this.BtnPersona.Size = new System.Drawing.Size(154, 29);
            this.BtnPersona.TabIndex = 7;
            this.BtnPersona.Text = "Ingresar Persona";
            this.BtnPersona.UseVisualStyleBackColor = true;
            this.BtnPersona.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Razon Social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Direccion";
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.Location = new System.Drawing.Point(48, 316);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(174, 29);
            this.BtnProveedor.TabIndex = 11;
            this.BtnProveedor.Text = "Ingresar Proveedor";
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Descripcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Proveedores";
            // 
            // BtnServicio
            // 
            this.BtnServicio.Location = new System.Drawing.Point(48, 476);
            this.BtnServicio.Name = "BtnServicio";
            this.BtnServicio.Size = new System.Drawing.Size(174, 29);
            this.BtnServicio.TabIndex = 15;
            this.BtnServicio.Text = "Ingresar Servicio";
            this.BtnServicio.UseVisualStyleBackColor = true;
            this.BtnServicio.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.BtnServicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPersona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DropProveedores);
            this.Controls.Add(this.NombreProv);
            this.Controls.Add(this.RazonProv);
            this.Controls.Add(this.DireccionPrvo);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.NombreSer);
            this.Controls.Add(this.DescripcionSer);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Segundo Parcial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox DescripcionSer;
        private System.Windows.Forms.TextBox NombreSer;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.TextBox DireccionPrvo;
        private System.Windows.Forms.TextBox RazonProv;
        private System.Windows.Forms.TextBox NombreProv;
        private System.Windows.Forms.ComboBox DropProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnServicio;
    }
}

