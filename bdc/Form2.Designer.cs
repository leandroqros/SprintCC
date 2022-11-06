
namespace bdc
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCDA = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.swTextbox3 = new BibliotecaDeClasses.SWTextbox();
            this.swTextbox2 = new BibliotecaDeClasses.SWTextbox();
            this.swTextbox1 = new BibliotecaDeClasses.SWTextbox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(25, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(72, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(51, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(51, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad de Armas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(51, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo de Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuarios";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(25, 44);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario:";
            // 
            // lblCDA
            // 
            this.lblCDA.AutoSize = true;
            this.lblCDA.Location = new System.Drawing.Point(25, 97);
            this.lblCDA.Name = "lblCDA";
            this.lblCDA.Size = new System.Drawing.Size(99, 13);
            this.lblCDA.TabIndex = 2;
            this.lblCDA.Text = "Cantidad de Armas:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 153);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo:";
            // 
            // swTextbox3
            // 
            this.swTextbox3.CampoVacio = false;
            this.swTextbox3.DatoPermitido = BibliotecaDeClasses.SWTextbox.TipoDeDato.Numero;
            this.swTextbox3.Location = new System.Drawing.Point(28, 169);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.NombreControl = null;
            this.swTextbox3.Size = new System.Drawing.Size(195, 20);
            this.swTextbox3.TabIndex = 6;
            // 
            // swTextbox2
            // 
            this.swTextbox2.CampoVacio = false;
            this.swTextbox2.DatoPermitido = BibliotecaDeClasses.SWTextbox.TipoDeDato.Numero;
            this.swTextbox2.Location = new System.Drawing.Point(28, 113);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NombreControl = null;
            this.swTextbox2.Size = new System.Drawing.Size(195, 20);
            this.swTextbox2.TabIndex = 5;
            // 
            // swTextbox1
            // 
            this.swTextbox1.CampoVacio = false;
            this.swTextbox1.DatoPermitido = BibliotecaDeClasses.SWTextbox.TipoDeDato.Numero;
            this.swTextbox1.Location = new System.Drawing.Point(28, 60);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NombreControl = null;
            this.swTextbox1.Size = new System.Drawing.Size(195, 20);
            this.swTextbox1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 246);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCDA);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label4);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCDA;
        private System.Windows.Forms.Label lblCodigo;
        private BibliotecaDeClasses.SWTextbox swTextbox1;
        private BibliotecaDeClasses.SWTextbox swTextbox2;
        private BibliotecaDeClasses.SWTextbox swTextbox3;
    }
}