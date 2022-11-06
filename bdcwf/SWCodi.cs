using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdcwf
{
    public partial class SWCodi : UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
        }

        public bool obligatorio
        {
            get;
            set;
        }

        public enum Aluno
        {
            GM,
            GS
        }
        private Aluno _formacion;
        public Aluno Formacion
        {
            get { return _formacion; }
            set { _formacion = value; }
        }

        private void ValidaCodigo()
        {
            if (_formacion.Equals(Aluno.GS))
            {
                if (obligatorio && txtCodi.Text.Length == 0)
                {
                    MessageBox.Show("Ese campo no puede estar vacio");
                    this.Focus();
                }
                else
                {
                    if (txtCodi.Text.Equals("S2AM"))
                    {
                        txtDesc.Text = "Desenvolupament aplicacions multiplataforma";
                    }
                    else if (txtCodi.Text.Equals("S2SX"))
                    {
                        txtDesc.Text = "Administració de sistemes Informatics en xarxa";
                    }
                    else
                    {
                        txtDesc.Text = "Codi incorrecte";
                        txtCodi.Focus();
                    }
                }
            }
            else if (_formacion.Equals(Aluno.GM))
            {
                if (obligatorio && txtCodi.Text.Length == 0)
                {
                    MessageBox.Show("Ese campo no puede estar vacio");
                    this.Focus();
                }
                else
                {
                    if (txtCodi.Text.Equals("M2SX"))
                    {
                        txtDesc.Text = "Sistemes MicroInformatics i Xarxes";
                    }
                    else
                    {
                        txtDesc.Text = "Codi incorrecte";
                        txtCodi.Focus();
                    }
                }
            }
        }

        private void txtCodi_Leave(object sender, EventArgs e)
        {
            ValidaCodigo();
        }
    }
}
