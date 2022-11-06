using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDeClasses
{
    public class SWTextbox : TextBox
    {
        public SWTextbox()
        {
            InitializeComponent();
        }

        //Propriedade Nombre texto o Codigo {
        public enum TipoDeDato
        {
            Numero,
            Texto,
            Codigo
        }

        private TipoDeDato _datoPermitido;
        public TipoDeDato DatoPermitido
        {
            get { return _datoPermitido; }
            set { _datoPermitido = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox
            // 
            this.DoubleClick += new System.EventHandler(this.SWTextbox_dobleclick);
            this.Enter += new System.EventHandler(this.SWTextbox_enter);
            this.Leave += new System.EventHandler(this.SWTextbox_leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextbox_validating);
            this.ResumeLayout(false);

        }

        //Cambiar color {
        private void SWTextbox_enter(object sender, EventArgs e)
        {
            this.BackColor = Color.FloralWhite;
        }

        private void SWTextbox_leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        //Booleanas
        public bool CampoVacio
        {
            get;
            set;
        }
        public bool EsForanea
        {
            get;
            set;
        }
        public string NombreControl
        {
            get;
            set;
        }

        private void SWTextbox_dobleclick(object sender, EventArgs e)
        {
            if (EsForanea)
            {
                MessageBox.Show("Clave foranea");
            }
        }

        private void SWTextbox_validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex rgxNum = new Regex(@"^[0-9]{1,}$");
            Regex rgxLetra = new Regex(@"^[a-zA-Z]{1,}$");
            Regex rgxCodigo = new Regex(@"^[^AEIOU]{4}\-\d{3}\/[13579][AEIOU]$");
            bool correcto;

            if (CampoVacio && this.Text.Length == 0)
            {
                MessageBox.Show("Ese campo no puede estar vacio");
                this.Focus();
            }
            else
            {
                if (DatoPermitido is TipoDeDato.Numero)
                {
                    correcto = rgxNum.IsMatch(this.Text);
                    if (!correcto)
                    {
                        this.Clear();
                        this.Focus();
                    }
                }

                if (DatoPermitido is TipoDeDato.Texto)
                {
                    correcto = rgxLetra.IsMatch(this.Text);
                    if (!correcto)
                    {
                        this.Clear();
                        this.Focus();
                    }
                }

                if (DatoPermitido is TipoDeDato.Codigo)
                {
                    correcto = rgxCodigo.IsMatch(this.Text);
                    if (!correcto)
                    {
                        this.Clear();
                        this.Focus();
                    }
                }
            }


            TextBox frmUno = (TextBox)sender;
            Form frm = frmUno.FindForm();
            if (string.IsNullOrEmpty(Text))
            {
                foreach (Control item in frmUno.Controls)
                {
                    if (item.Name.Equals(NombreControl))
                    {
                        item.Text = this.Text;
                    }
                }

            }
            else
            {
                this.Text = Text;
            }
        }
    }
}
