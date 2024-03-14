namespace WinCom
{
    partial class frmApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApp));
            this.apPdf = new AxAcroPDFLib.AxAcroPDF();
            this.lblVideo = new System.Windows.Forms.Label();
            this.lblPdf = new System.Windows.Forms.Label();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.wbBuscador = new AxSHDocVw.AxWebBrowser();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbBuscador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // apPdf
            // 
            this.apPdf.Enabled = true;
            this.apPdf.Location = new System.Drawing.Point(315, 65);
            this.apPdf.Name = "apPdf";
            this.apPdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("apPdf.OcxState")));
            this.apPdf.Size = new System.Drawing.Size(244, 180);
            this.apPdf.TabIndex = 1;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(111, 22);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(80, 23);
            this.lblVideo.TabIndex = 3;
            this.lblVideo.Text = "VIDEO";
            // 
            // lblPdf
            // 
            this.lblPdf.AutoSize = true;
            this.lblPdf.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdf.Location = new System.Drawing.Point(383, 22);
            this.lblPdf.Name = "lblPdf";
            this.lblPdf.Size = new System.Drawing.Size(54, 23);
            this.lblPdf.TabIndex = 4;
            this.lblPdf.Text = "PDF";
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.Location = new System.Drawing.Point(606, 22);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(191, 23);
            this.lblBuscador.TabIndex = 5;
            this.lblBuscador.Text = "BUSCADOR WEB";
            // 
            // btnReproducir
            // 
            this.btnReproducir.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReproducir.Location = new System.Drawing.Point(97, 308);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(125, 41);
            this.btnReproducir.TabIndex = 6;
            this.btnReproducir.Text = "REPRODUCIR";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // wbBuscador
            // 
            this.wbBuscador.Enabled = true;
            this.wbBuscador.Location = new System.Drawing.Point(547, 65);
            this.wbBuscador.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wbBuscador.OcxState")));
            this.wbBuscador.Size = new System.Drawing.Size(325, 223);
            this.wbBuscador.TabIndex = 2;
            this.wbBuscador.Enter += new System.EventHandler(this.wbBuscador_Enter);
            // 
            // wmpVideo
            // 
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(30, 65);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(263, 224);
            this.wmpVideo.TabIndex = 0;
            // 
            // btnPdf
            // 
            this.btnPdf.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPdf.Location = new System.Drawing.Point(340, 308);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(153, 37);
            this.btnPdf.TabIndex = 7;
            this.btnPdf.Text = "ABRIR PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(644, 308);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 37);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 504);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.lblPdf);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.wbBuscador);
            this.Controls.Add(this.apPdf);
            this.Controls.Add(this.wmpVideo);
            this.Name = "frmApp";
            this.Text = "APP";
            this.Load += new System.EventHandler(this.frmApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbBuscador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private AxAcroPDFLib.AxAcroPDF apPdf;
        private AxSHDocVw.AxWebBrowser wbBuscador;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Label lblPdf;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnBuscar;
    }
}

