namespace FrmTest
{
    partial class FormTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstStock = new System.Windows.Forms.ListBox();
            this.rtbInformes = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerInforme = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstStock);
            this.panel1.Controls.Add(this.rtbInformes);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnVerInforme);
            this.panel1.Controls.Add(this.btnVender);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 705);
            this.panel1.TabIndex = 0;
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.ItemHeight = 16;
            this.lstStock.Items.AddRange(new object[] {
            "Life (Keith Richards)",
            "White line fever (Lemmy)",
            "Commando (Johnny Ramone)",
            "La Muerte de Superman (Superman)",
            "Año Uno (Batman)"});
            this.lstStock.Location = new System.Drawing.Point(26, 11);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(370, 404);
            this.lstStock.TabIndex = 4;
           // this.lstStock.SelectedIndex = 0;
            // 
            // rtbInformes
            // 
            this.rtbInformes.Enabled = false;
            this.rtbInformes.Location = new System.Drawing.Point(402, 11);
            this.rtbInformes.Name = "rtbInformes";
            this.rtbInformes.Size = new System.Drawing.Size(364, 679);
            this.rtbInformes.TabIndex = 3;
            this.rtbInformes.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(26, 625);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(365, 65);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerInforme
            // 
            this.btnVerInforme.Location = new System.Drawing.Point(26, 530);
            this.btnVerInforme.Name = "btnVerInforme";
            this.btnVerInforme.Size = new System.Drawing.Size(364, 65);
            this.btnVerInforme.TabIndex = 1;
            this.btnVerInforme.Text = "Ver Informe";
            this.btnVerInforme.UseVisualStyleBackColor = true;
            this.btnVerInforme.Click += new System.EventHandler(this.btnVerInforme_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(25, 436);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(365, 65);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 718);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test App de Magali Gracia 2°D";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            //
            // Vendedor
            //
            this.vendedor = new Parcial.Vendedor("Pepito");

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbInformes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerInforme;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.ListBox lstStock;
        private Parcial.Vendedor vendedor;
    }
}

