namespace Catalogo
{
    partial class FMRListarCategoria
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
            this.DGVListaCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVListaCategoria
            // 
            this.DGVListaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaCategoria.Location = new System.Drawing.Point(12, 12);
            this.DGVListaCategoria.Name = "DGVListaCategoria";
            this.DGVListaCategoria.Size = new System.Drawing.Size(508, 247);
            this.DGVListaCategoria.TabIndex = 0;
            // 
            // FMRListarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 282);
            this.Controls.Add(this.DGVListaCategoria);
            this.Name = "FMRListarCategoria";
            this.Text = "Listar Categoria";
            this.Load += new System.EventHandler(this.FMRListarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListaCategoria;
    }
}