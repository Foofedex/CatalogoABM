namespace Catalogo
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
            this.txtBusquedad = new System.Windows.Forms.TextBox();
            this.lbl_busquedad = new System.Windows.Forms.Label();
            this.btnBusquedad = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBusquedad
            // 
            this.txtBusquedad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBusquedad.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtBusquedad, "txtBusquedad");
            this.txtBusquedad.Name = "txtBusquedad";
            this.txtBusquedad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_busquedad
            // 
            resources.ApplyResources(this.lbl_busquedad, "lbl_busquedad");
            this.lbl_busquedad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_busquedad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_busquedad.Name = "lbl_busquedad";
            // 
            // btnBusquedad
            // 
            this.btnBusquedad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBusquedad.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBusquedad, "btnBusquedad");
            this.btnBusquedad.Name = "btnBusquedad";
            this.btnBusquedad.UseVisualStyleBackColor = false;
            this.btnBusquedad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnVolver, "btnVolver");
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBusquedad);
            this.Controls.Add(this.lbl_busquedad);
            this.Controls.Add(this.txtBusquedad);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedad;
        private System.Windows.Forms.Label lbl_busquedad;
        private System.Windows.Forms.Button btnBusquedad;
        private System.Windows.Forms.Button btnVolver;
    }
}