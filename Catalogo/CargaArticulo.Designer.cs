namespace Catalogo
{
    partial class FMRArticulo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMRArticulo));
            this.LBLNombre = new System.Windows.Forms.Label();
            this.LBLID = new System.Windows.Forms.Label();
            this.LBLDescripcion = new System.Windows.Forms.Label();
            this.LBLMarca = new System.Windows.Forms.Label();
            this.LBLCategoria = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LBLPrecio = new System.Windows.Forms.Label();
            this.TXTBID = new System.Windows.Forms.TextBox();
            this.TXTBNombre = new System.Windows.Forms.TextBox();
            this.TXTBDescripcion = new System.Windows.Forms.TextBox();
            this.TXTBMarca = new System.Windows.Forms.TextBox();
            this.TXTBCategoria = new System.Windows.Forms.TextBox();
            this.TXTBPrecio = new System.Windows.Forms.TextBox();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNEdit = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.Location = new System.Drawing.Point(30, 64);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(62, 15);
            this.LBLNombre.TabIndex = 0;
            this.LBLNombre.Text = "Nombre:";
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Location = new System.Drawing.Point(32, 26);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(60, 15);
            this.LBLID.TabIndex = 1;
            this.LBLID.Text = "Codigo :";
            // 
            // LBLDescripcion
            // 
            this.LBLDescripcion.AutoSize = true;
            this.LBLDescripcion.Location = new System.Drawing.Point(5, 101);
            this.LBLDescripcion.Name = "LBLDescripcion";
            this.LBLDescripcion.Size = new System.Drawing.Size(87, 15);
            this.LBLDescripcion.TabIndex = 3;
            this.LBLDescripcion.Text = "Descripcion:";
            // 
            // LBLMarca
            // 
            this.LBLMarca.AutoSize = true;
            this.LBLMarca.Location = new System.Drawing.Point(45, 143);
            this.LBLMarca.Name = "LBLMarca";
            this.LBLMarca.Size = new System.Drawing.Size(47, 15);
            this.LBLMarca.TabIndex = 4;
            this.LBLMarca.Text = "Marca";
            // 
            // LBLCategoria
            // 
            this.LBLCategoria.AutoSize = true;
            this.LBLCategoria.Location = new System.Drawing.Point(23, 177);
            this.LBLCategoria.Name = "LBLCategoria";
            this.LBLCategoria.Size = new System.Drawing.Size(69, 15);
            this.LBLCategoria.TabIndex = 5;
            this.LBLCategoria.Text = "Categoria";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(120, 120);
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            // 
            // LBLPrecio
            // 
            this.LBLPrecio.AutoSize = true;
            this.LBLPrecio.Location = new System.Drawing.Point(36, 221);
            this.LBLPrecio.Name = "LBLPrecio";
            this.LBLPrecio.Size = new System.Drawing.Size(56, 15);
            this.LBLPrecio.TabIndex = 6;
            this.LBLPrecio.Text = "Precio :";
            // 
            // TXTBID
            // 
            this.TXTBID.AcceptsReturn = true;
            this.TXTBID.AcceptsTab = true;
            this.TXTBID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBID.Location = new System.Drawing.Point(99, 23);
            this.TXTBID.Name = "TXTBID";
            this.TXTBID.Size = new System.Drawing.Size(203, 21);
            this.TXTBID.TabIndex = 7;
            // 
            // TXTBNombre
            // 
            this.TXTBNombre.AcceptsReturn = true;
            this.TXTBNombre.AcceptsTab = true;
            this.TXTBNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBNombre.Location = new System.Drawing.Point(99, 58);
            this.TXTBNombre.Name = "TXTBNombre";
            this.TXTBNombre.Size = new System.Drawing.Size(203, 21);
            this.TXTBNombre.TabIndex = 8;
            // 
            // TXTBDescripcion
            // 
            this.TXTBDescripcion.AcceptsReturn = true;
            this.TXTBDescripcion.AcceptsTab = true;
            this.TXTBDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBDescripcion.Location = new System.Drawing.Point(99, 98);
            this.TXTBDescripcion.Name = "TXTBDescripcion";
            this.TXTBDescripcion.Size = new System.Drawing.Size(203, 21);
            this.TXTBDescripcion.TabIndex = 9;
            // 
            // TXTBMarca
            // 
            this.TXTBMarca.AcceptsReturn = true;
            this.TXTBMarca.AcceptsTab = true;
            this.TXTBMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBMarca.Location = new System.Drawing.Point(99, 140);
            this.TXTBMarca.Name = "TXTBMarca";
            this.TXTBMarca.Size = new System.Drawing.Size(203, 21);
            this.TXTBMarca.TabIndex = 10;
            // 
            // TXTBCategoria
            // 
            this.TXTBCategoria.AcceptsReturn = true;
            this.TXTBCategoria.AcceptsTab = true;
            this.TXTBCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBCategoria.Location = new System.Drawing.Point(99, 174);
            this.TXTBCategoria.Name = "TXTBCategoria";
            this.TXTBCategoria.Size = new System.Drawing.Size(203, 21);
            this.TXTBCategoria.TabIndex = 11;
            // 
            // TXTBPrecio
            // 
            this.TXTBPrecio.AcceptsReturn = true;
            this.TXTBPrecio.AcceptsTab = true;
            this.TXTBPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBPrecio.Location = new System.Drawing.Point(98, 215);
            this.TXTBPrecio.Name = "TXTBPrecio";
            this.TXTBPrecio.Size = new System.Drawing.Size(203, 21);
            this.TXTBPrecio.TabIndex = 12;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(98, 272);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(75, 23);
            this.BTNAdd.TabIndex = 13;
            this.BTNAdd.Text = "Agregar";
            this.BTNAdd.UseVisualStyleBackColor = true;
            // 
            // BTNEdit
            // 
            this.BTNEdit.Location = new System.Drawing.Point(179, 272);
            this.BTNEdit.Name = "BTNEdit";
            this.BTNEdit.Size = new System.Drawing.Size(75, 23);
            this.BTNEdit.TabIndex = 14;
            this.BTNEdit.Text = "Editar";
            this.BTNEdit.UseVisualStyleBackColor = true;
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(260, 272);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(75, 23);
            this.BTNDelete.TabIndex = 15;
            this.BTNDelete.Text = "Eliminar";
            this.BTNDelete.UseVisualStyleBackColor = true;
            // 
            // BTNBack
            // 
            this.BTNBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.BTNBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNBack.Image = ((System.Drawing.Image)(resources.GetObject("BTNBack.Image")));
            this.BTNBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBack.Location = new System.Drawing.Point(420, 309);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(78, 25);
            this.BTNBack.TabIndex = 16;
            this.BTNBack.Text = "Volver";
            this.BTNBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBack.UseVisualStyleBackColor = true;
            // 
            // FMRArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 349);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNEdit);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.TXTBPrecio);
            this.Controls.Add(this.TXTBCategoria);
            this.Controls.Add(this.TXTBMarca);
            this.Controls.Add(this.TXTBDescripcion);
            this.Controls.Add(this.TXTBNombre);
            this.Controls.Add(this.TXTBID);
            this.Controls.Add(this.LBLPrecio);
            this.Controls.Add(this.LBLCategoria);
            this.Controls.Add(this.LBLMarca);
            this.Controls.Add(this.LBLDescripcion);
            this.Controls.Add(this.LBLID);
            this.Controls.Add(this.LBLNombre);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FMRArticulo";
            this.Text = "Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.Label LBLDescripcion;
        private System.Windows.Forms.Label LBLMarca;
        private System.Windows.Forms.Label LBLCategoria;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label LBLPrecio;
        private System.Windows.Forms.TextBox TXTBID;
        private System.Windows.Forms.TextBox TXTBNombre;
        private System.Windows.Forms.TextBox TXTBDescripcion;
        private System.Windows.Forms.TextBox TXTBMarca;
        private System.Windows.Forms.TextBox TXTBCategoria;
        private System.Windows.Forms.TextBox TXTBPrecio;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNEdit;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNBack;
    }
}