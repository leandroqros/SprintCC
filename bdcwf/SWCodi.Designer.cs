
namespace bdcwf
{
    partial class SWCodi
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodi = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodi
            // 
            this.txtCodi.Location = new System.Drawing.Point(14, 12);
            this.txtCodi.Name = "txtCodi";
            this.txtCodi.Size = new System.Drawing.Size(100, 20);
            this.txtCodi.TabIndex = 0;
            this.txtCodi.Leave += new System.EventHandler(this.txtCodi_Leave);
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(129, 12);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(234, 20);
            this.txtDesc.TabIndex = 1;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCodi);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(384, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodi;
        private System.Windows.Forms.TextBox txtDesc;
    }
}
