namespace Form2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAtras = new System.Windows.Forms.ToolStripButton();
            this.btnAdelante = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.txtURL = new System.Windows.Forms.ToolStripTextBox();
            this.btnIr = new System.Windows.Forms.ToolStripButton();
            this.wbNavegador = new System.Windows.Forms.WebBrowser();
            this.btnFavoritos = new System.Windows.Forms.ToolStripButton();
            this.cbFavoritos = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtras,
            this.btnAdelante,
            this.btnRefrescar,
            this.btnHome,
            this.txtURL,
            this.btnIr,
            this.btnFavoritos,
            this.cbFavoritos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1207, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAtras
            // 
            this.btnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(34, 28);
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdelante.Image = ((System.Drawing.Image)(resources.GetObject("btnAdelante.Image")));
            this.btnAdelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(34, 33);
            this.btnAdelante.Text = "Adelante";
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(34, 33);
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(34, 33);
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtURL
            // 
            this.txtURL.AutoSize = false;
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(800, 33);
            this.txtURL.Click += new System.EventHandler(this.txtURL_Click);
            // 
            // btnIr
            // 
            this.btnIr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIr.Image = ((System.Drawing.Image)(resources.GetObject("btnIr.Image")));
            this.btnIr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(34, 28);
            this.btnIr.Text = "Buscar";
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // wbNavegador
            // 
            this.wbNavegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbNavegador.Location = new System.Drawing.Point(0, 33);
            this.wbNavegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNavegador.Name = "wbNavegador";
            this.wbNavegador.Size = new System.Drawing.Size(1207, 417);
            this.wbNavegador.TabIndex = 1;
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFavoritos.Image = ((System.Drawing.Image)(resources.GetObject("btnFavoritos.Image")));
            this.btnFavoritos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(34, 28);
            this.btnFavoritos.Text = "Favoritos";
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // cbFavoritos
            // 
            this.cbFavoritos.Name = "cbFavoritos";
            this.cbFavoritos.Size = new System.Drawing.Size(121, 33);
            this.cbFavoritos.Click += new System.EventHandler(this.cbFavoritos_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 450);
            this.Controls.Add(this.wbNavegador);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAtras;
        private System.Windows.Forms.ToolStripButton btnAdelante;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripTextBox txtURL;
        private System.Windows.Forms.ToolStripButton btnIr;
        private System.Windows.Forms.WebBrowser wbNavegador;
        private System.Windows.Forms.ToolStripButton btnFavoritos;
        private System.Windows.Forms.ToolStripComboBox cbFavoritos;
    }
}