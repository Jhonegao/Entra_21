using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SobreMetodos
{
    public partial class Metodos : Form
    {
        //incialmente para aprender sobre metodos usaremos metodos dentro do proprio form.
        public Metodos()
        {
            InitializeComponent();
        }
        //public/private por hora irrelevante pois estara tudo no mesmo metodo.

        private bool VerificarMaiorIdade(int p_idade)
        {
            //retorna o resultado da comparacao abaixo para o bool
            return p_idade >= 18;
        }
        private string IsValidName(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return $"Nome inválido";
            }
            else if (nome.Length < 3 || nome.Length > 50)
            {
                return $"o nome deve conter de 3 a 50 caracteres";
            }
            return "";
        }
    }
}
