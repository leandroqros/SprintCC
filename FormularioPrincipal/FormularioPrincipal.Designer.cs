
namespace FormularioPrincipal
{
    partial class FormPrincipal
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
            this.selectorDeForm3 = new bibliotecadeclase.SelectorDeForm();
            this.selectorDeForm2 = new bibliotecadeclase.SelectorDeForm();
            this.selectorDeForm1 = new bibliotecadeclase.SelectorDeForm();
            this.SuspendLayout();
            // 
            // selectorDeForm3
            // 
            this.selectorDeForm3.Classe = "bdc";
            this.selectorDeForm3.Descripcion = "Ejemplo3";
            this.selectorDeForm3.Location = new System.Drawing.Point(462, 12);
            this.selectorDeForm3.Name = "selectorDeForm3";
            this.selectorDeForm3.NombreFormulario = "Form3";
            this.selectorDeForm3.Size = new System.Drawing.Size(219, 102);
            this.selectorDeForm3.TabIndex = 2;
            // 
            // selectorDeForm2
            // 
            this.selectorDeForm2.Classe = "bdc";
            this.selectorDeForm2.Descripcion = "Usuarios del Sistema";
            this.selectorDeForm2.Location = new System.Drawing.Point(237, 12);
            this.selectorDeForm2.Name = "selectorDeForm2";
            this.selectorDeForm2.NombreFormulario = "Form2";
            this.selectorDeForm2.Size = new System.Drawing.Size(219, 102);
            this.selectorDeForm2.TabIndex = 1;
            // 
            // selectorDeForm1
            // 
            this.selectorDeForm1.Classe = "bdc";
            this.selectorDeForm1.Descripcion = "Nivel de Estudio";
            this.selectorDeForm1.Location = new System.Drawing.Point(12, 12);
            this.selectorDeForm1.Name = "selectorDeForm1";
            this.selectorDeForm1.NombreFormulario = "Form1";
            this.selectorDeForm1.Size = new System.Drawing.Size(219, 102);
            this.selectorDeForm1.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 129);
            this.Controls.Add(this.selectorDeForm3);
            this.Controls.Add(this.selectorDeForm2);
            this.Controls.Add(this.selectorDeForm1);
            this.Name = "FormPrincipal";
            this.Text = "Formulario de Seleccion";
            this.ResumeLayout(false);

        }

        #endregion

        private bibliotecadeclase.SelectorDeForm selectorDeForm1;
        private bibliotecadeclase.SelectorDeForm selectorDeForm2;
        private bibliotecadeclase.SelectorDeForm selectorDeForm3;
    }
}

