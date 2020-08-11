using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using Correios.CEP;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region ValidadorNome
        private string IsValidName(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "O nome deve ser informado.\r\n";
            }
            else if (nome.Length < 3 || nome.Length > 50)
            {
                return "O nome deve conter entre 3 e 50 caracteres.\r\n";
            }
            return "";
        }
        #endregion
        #region ValidadorCPF
        private string IsValidCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return "O cpf deve conter 11 caracteres.\r\n";
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            bool cpfEhValido = cpf.EndsWith(digito);
            if (cpfEhValido)
            {
                return "";
            }
            return "Cpf inválido.\r\n";
        }
        #endregion
        #region ValidadorEmail
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        #endregion
        #region ValidadorDDD
        public static bool IsValidDDD(string numeroDDD)
        {
            if (string.IsNullOrWhiteSpace(numeroDDD))
                return false;
            var r = new Regex(@"^\(([0-9]{2})\)$");
                return r.IsMatch(numeroDDD);
        }
        #endregion
        #region ValidadorTelefone
        public bool IsValidTelefone(string numeroTelefone)
        {
            if (string.IsNullOrWhiteSpace(numeroTelefone))
                return false;
            var r = new Regex(@"^\(?([0-9]{5})\)?[-]?([0-9]{4})$");
            return r.IsMatch(numeroTelefone);
        }
        #endregion
        #region Endereco
        private void LocalizarCEP()
        {
            if (!string.IsNullOrWhiteSpace(txtEntradaCEP.Text))
            {
                try
                {
                    var endereco = correiosCEP.GetAddress(txtEntradaCEP.Text);
                    if (endereco.Cep != null)
                    {
                        txtEntradaEstado.Text = endereco.UF;
                        txtEntradaCidade.Text = endereco.Cidade;
                        txtEntradaBairro.Text = endereco.Bairro;
                        txtEntradaRua.Text = endereco.Rua;
                        txtNumeroEnderecoEntrada.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("CEP NÃO ENCONTRADO");
                    txtEntradaEstado.Clear();
                    txtEntradaCidade.Clear();
                    txtEntradaBairro.Clear();
                    txtEntradaRua.Clear();
                    txtNumeroEnderecoEntrada.Enabled = false;
                    return;
                }
            }         

        }
        #endregion

        #region ValidarCadastroGERAL
        private string ValidarCadastro(string p_nome, string p_cpf, int p_idade)
        {
            string erros = "";
            erros += IsValidName(p_nome);
            erros += IsValidCpf(p_cpf);
            //Para por um método dentro de um if, ele deve retornar bool!
            if (erros == "")
            {
                return "Cliente validado com sucesso!";
            }
            return erros;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(IsValidPhone(txtEntradaDDD.Text).ToString());


        }

        private void txtEntradaCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }
    }
}
