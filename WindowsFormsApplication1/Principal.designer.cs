namespace WindowsFormsApplication1
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquemaDeMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeResultadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pROMEDIOPONDERADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uEPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanzaDeComprobaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoDeResultadoToolStripMenuItem,
            this.esquemaDeMayorToolStripMenuItem,
            this.estadoDeResultadoToolStripMenuItem1,
            this.pROMEDIOPONDERADOToolStripMenuItem,
            this.uEPSToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.opcionesToolStripMenuItem.Text = "Formulario";
            // 
            // estadoDeResultadoToolStripMenuItem
            // 
            this.estadoDeResultadoToolStripMenuItem.Name = "estadoDeResultadoToolStripMenuItem";
            this.estadoDeResultadoToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.estadoDeResultadoToolStripMenuItem.Text = "Balanza de Comprobación";
            this.estadoDeResultadoToolStripMenuItem.Click += new System.EventHandler(this.estadoDeResultadoToolStripMenuItem_Click);
            // 
            // esquemaDeMayorToolStripMenuItem
            // 
            this.esquemaDeMayorToolStripMenuItem.Name = "esquemaDeMayorToolStripMenuItem";
            this.esquemaDeMayorToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.esquemaDeMayorToolStripMenuItem.Text = "Esquema de Mayor";
            this.esquemaDeMayorToolStripMenuItem.Click += new System.EventHandler(this.esquemaDeMayorToolStripMenuItem_Click);
            // 
            // estadoDeResultadoToolStripMenuItem1
            // 
            this.estadoDeResultadoToolStripMenuItem1.Name = "estadoDeResultadoToolStripMenuItem1";
            this.estadoDeResultadoToolStripMenuItem1.Size = new System.Drawing.Size(266, 24);
            this.estadoDeResultadoToolStripMenuItem1.Text = "Estado de Resultado";
            this.estadoDeResultadoToolStripMenuItem1.Click += new System.EventHandler(this.estadoDeResultadoToolStripMenuItem1_Click);
            // 
            // pROMEDIOPONDERADOToolStripMenuItem
            // 
            this.pROMEDIOPONDERADOToolStripMenuItem.Name = "pROMEDIOPONDERADOToolStripMenuItem";
            this.pROMEDIOPONDERADOToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.pROMEDIOPONDERADOToolStripMenuItem.Text = "Promedio Ponderado";
            this.pROMEDIOPONDERADOToolStripMenuItem.Click += new System.EventHandler(this.pROMEDIOPONDERADOToolStripMenuItem_Click);
            // 
            // uEPSToolStripMenuItem
            // 
            this.uEPSToolStripMenuItem.Name = "uEPSToolStripMenuItem";
            this.uEPSToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.uEPSToolStripMenuItem.Text = "UEPS";
            this.uEPSToolStripMenuItem.Click += new System.EventHandler(this.uEPSToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanzaDeComprobaciónToolStripMenuItem});
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.verAyudaToolStripMenuItem.Text = "Ver ayuda";
            // 
            // balanzaDeComprobaciónToolStripMenuItem
            // 
            this.balanzaDeComprobaciónToolStripMenuItem.Name = "balanzaDeComprobaciónToolStripMenuItem";
            this.balanzaDeComprobaciónToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.balanzaDeComprobaciónToolStripMenuItem.Text = "Balanza de Comprobación";
            // 
            // opcionesToolStripMenuItem1
            // 
            this.opcionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem1.Name = "opcionesToolStripMenuItem1";
            this.opcionesToolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.opcionesToolStripMenuItem1.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.opcionesToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btncerrar.Location = new System.Drawing.Point(1328, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(36, 35);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.Transparent;
            this.btnmin.Location = new System.Drawing.Point(1291, 0);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(36, 35);
            this.btnmin.TabIndex = 6;
            this.btnmin.Text = "--";
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fceos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeResultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquemaDeMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeResultadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanzaDeComprobaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.ToolStripMenuItem pROMEDIOPONDERADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uEPSToolStripMenuItem;
    }
}

