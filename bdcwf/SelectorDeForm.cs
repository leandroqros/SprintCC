using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecadeclase
{
    /// <summary>
    /// Control heredado de un CustomControl
    /// </summary>
    /// <param name="SelectorDeForm : UserControl"> Comando para heredar propiedades de UserControl</param>
    /// <example> MiCustomTextBox : Textbox </example>
    public partial class SelectorDeForm : UserControl
    {
        public SelectorDeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Propiedad donde aplicamos la Clase
        /// </summary>
        public string Classe
        {
            get;
            set;
        }

        /// <summary>
        /// Propiedad donde aplicamos el nombre del Formulario
        /// </summary>
        public string NombreFormulario
        {
            get;
            set;
        }
        /// <summary>
        /// Propiedad donde aplicamos la descripcion del Formulario
        /// </summary>
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
