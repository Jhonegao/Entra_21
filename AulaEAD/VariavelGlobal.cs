using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaEAD
{
    public partial class VariavelDaClasse : Form
    {
        public VariavelDaClasse()
        {
            InitializeComponent();
        }
        int numero = 0;

        //declaracao da variavel dentro do evento não ira funcionar.
        private void btnIncrement_Click(object sender, EventArgs e)
        {
            numero++;
            lbNum.Text = numero.ToString();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            numero--;
            lbNum.Text = numero.ToString();
        }
    }
}
