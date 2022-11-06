
namespace FormularioPrincipal
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
            this.swTextbox1 = new BibliotecaDeClasses.SWTextbox();
            this.swTextbox2 = new BibliotecaDeClasses.SWTextbox();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.DatoPermitido = BibliotecaDeClasses.SWTextbox.TipoDeDato.Numero;
            this.swTextbox1.Location = new System.Drawing.Point(115, 74);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.TabIndex = 0;
            // 
            // swTextbox2
            // 
            this.swTextbox2.DatoPermitido = BibliotecaDeClasses.SWTextbox.TipoDeDato.Numero;
            this.swTextbox2.Location = new System.Drawing.Point(146, 161);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(100, 20);
            this.swTextbox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDeClasses.SWTextbox swTextbox1;
        private BibliotecaDeClasses.SWTextbox swTextbox2;
    }
}

