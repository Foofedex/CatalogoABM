namespace Catalogo
{
    partial class FMRListarMarca
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
            this.DGVListadoMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListadoMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVListadoMarcas
            // 
            this.DGVListadoMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListadoMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListadoMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVListadoMarcas.Location = new System.Drawing.Point(-1, -2);
            this.DGVListadoMarcas.Name = "DGVListadoMarcas";
            this.DGVListadoMarcas.Size = new System.Drawing.Size(485, 300);
            this.DGVListadoMarcas.TabIndex = 0;
            // 
            // FMRListarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 297);
            this.Controls.Add(this.DGVListadoMarcas);
            this.Name = "FMRListarMarca";
            this.Text = "Listado  de Marcas";
            this.Load += new System.EventHandler(this.FMRListarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListadoMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListadoMarcas;
    }
}