namespace ClinicaVeterinariaApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonMascotas = new System.Windows.Forms.Button();
            this.buttonCitas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMostrar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(347, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clínica Veterinaria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonClientes.Font = new System.Drawing.Font("Impact", 8.25F);
            this.buttonClientes.ForeColor = System.Drawing.Color.Black;
            this.buttonClientes.Location = new System.Drawing.Point(13, 65);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(116, 39);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonMascotas
            // 
            this.buttonMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonMascotas.Font = new System.Drawing.Font("Impact", 8.25F);
            this.buttonMascotas.Location = new System.Drawing.Point(13, 153);
            this.buttonMascotas.Name = "buttonMascotas";
            this.buttonMascotas.Size = new System.Drawing.Size(116, 39);
            this.buttonMascotas.TabIndex = 2;
            this.buttonMascotas.Text = "Mascotas";
            this.buttonMascotas.UseVisualStyleBackColor = false;
            this.buttonMascotas.Click += new System.EventHandler(this.buttonMascotas_Click);
            // 
            // buttonCitas
            // 
            this.buttonCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCitas.Font = new System.Drawing.Font("Impact", 8.25F);
            this.buttonCitas.Location = new System.Drawing.Point(13, 239);
            this.buttonCitas.Name = "buttonCitas";
            this.buttonCitas.Size = new System.Drawing.Size(116, 39);
            this.buttonCitas.TabIndex = 3;
            this.buttonCitas.Text = "Citas";
            this.buttonCitas.UseVisualStyleBackColor = false;
            this.buttonCitas.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.buttonClientes);
            this.panel1.Controls.Add(this.buttonMascotas);
            this.panel1.Controls.Add(this.buttonCitas);
            this.panel1.Location = new System.Drawing.Point(-1, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 537);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1286, 92);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 91);
            this.panel3.TabIndex = 1;
            // 
            // panelMostrar
            // 
            this.panelMostrar.Location = new System.Drawing.Point(143, 90);
            this.panelMostrar.Margin = new System.Windows.Forms.Padding(0);
            this.panelMostrar.Name = "panelMostrar";
            this.panelMostrar.Size = new System.Drawing.Size(1142, 537);
            this.panelMostrar.TabIndex = 7;
            this.panelMostrar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMostrar_Paint_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1285, 628);
            this.Controls.Add(this.panelMostrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Veterinaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonMascotas;
        private System.Windows.Forms.Button buttonCitas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMostrar;
    }
}

