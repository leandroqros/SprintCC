using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace bibliotecadeclase
{
    public partial class SelectorDeForm : UserControl
    {
        public SelectorDeForm()
        {
            InitializeComponent();
        }
        public string Classe
        {
            get;
            set;
        }

        public string NombreFormulario
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        private void bntEntrar_click(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom(@"" + Classe + ".dll");

            Object dll;
            Type tipo;

            tipo = ensamblat.GetType(Classe + "." + NombreFormulario);
            dll = Activator.CreateInstance(tipo);

            ((Form)dll).Show();
        }

        private void SelectorDeForm_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Descripcion;
        }
    }
}
