
namespace bdc
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltitol = new System.Windows.Forms.Label();
            this.lblGm = new System.Windows.Forms.Label();
            this.lblGS = new System.Windows.Forms.Label();
            this.swCodi1 = new bdcwf.SWCodi();
            this.swCodi2 = new bdcwf.SWCodi();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Estudios de los alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "GM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "GS";
            // 
            // lbltitol
            // 
            this.lbltitol.AutoSize = true;
            this.lbltitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitol.Location = new System.Drawing.Point(12, 9);
            this.lbltitol.Name = "lbltitol";
            this.lbltitol.Size = new System.Drawing.Size(168, 20);
            this.lbltitol.TabIndex = 0;
            this.lbltitol.Text = "Estudios de los alunos";
            // 
            // lblGm
            // 
            this.lblGm.AutoSize = true;
            this.lblGm.Location = new System.Drawing.Point(59, 50);
            this.lblGm.Name = "lblGm";
            this.lblGm.Size = new System.Drawing.Size(24, 13);
            this.lblGm.TabIndex = 1;
            this.lblGm.Text = "GM";
            // 
            // lblGS
            // 
            this.lblGS.AutoSize = true;
            this.lblGS.Location = new System.Drawing.Point(61, 114);
            this.lblGS.Name = "lblGS";
            this.lblGS.Size = new System.Drawing.Size(22, 13);
            this.lblGS.TabIndex = 2;
            this.lblGS.Text = "GS";
            // 
            // swCodi1
            // 
            this.swCodi1.Formacion = bdcwf.SWCodi.Aluno.GM;
            this.swCodi1.Location = new System.Drawing.Point(47, 66);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.obligatorio = true;
            this.swCodi1.Size = new System.Drawing.Size(384, 45);
            this.swCodi1.TabIndex = 3;
            // 
            // swCodi2
            // 
            this.swCodi2.Formacion = bdcwf.SWCodi.Aluno.GS;
            this.swCodi2.Location = new System.Drawing.Point(47, 130);
            this.swCodi2.Name = "swCodi2";
            this.swCodi2.obligatorio = true;
            this.swCodi2.Size = new System.Drawing.Size(384, 45);
            this.swCodi2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 231);
            this.Controls.Add(this.swCodi2);
            this.Controls.Add(this.swCodi1);
            this.Controls.Add(this.lblGS);
            this.Controls.Add(this.lblGm);
            this.Controls.Add(this.lbltitol);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltitol;
        private System.Windows.Forms.Label lblGm;
        private System.Windows.Forms.Label lblGS;
        private bdcwf.SWCodi swCodi1;
        private bdcwf.SWCodi swCodi2;
    }
}