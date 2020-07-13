using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class FormMenuExercicios1 : Form
    {
        public FormMenuExercicios1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            Form f = new Exercicio1();
            f.ShowDialog();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            Form f = new Exercicio2();
            f.ShowDialog();
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            Form f = new Exercicio3();
            f.ShowDialog();
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            Form f = new Exercicio4();
            f.ShowDialog();
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            Form f = new Exercicio5();
            f.ShowDialog();
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            Form f = new Exercicio6();
            f.ShowDialog();
        }

        private void btnExercicio7_Click(object sender, EventArgs e)
        {
            Form f = new Exercicio7();
            f.ShowDialog();
        }

        private void btnExercicio8_Click(object sender, EventArgs e)
        {
            Form f = new Exercicio8();
            f.ShowDialog();
        }
    }
}
