using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_1
{
    public partial class frmpropriedadescheckbox : Form
    {
        public frmpropriedadescheckbox()
        {
            InitializeComponent();
        }

        private void button1_click_1(object sender, EventArgs e)
        {
            frmpropriedadescheckbox propriedades = new frmpropriedadescheckbox(); // instanciando o formulario
            propriedades.ShowDialog(); //o formulario é exibido atravez do metodo  showdialog
        }

        private void btnavancar_Click(object sender, EventArgs e)
        {
            cadastro novo = new cadastro();
            novo.Show();
            
        }
    }
}
