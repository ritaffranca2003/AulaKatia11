using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaKatia11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Funcionamento f = new Funcionamento();

        private void btnferias_Click(object sender, EventArgs e)
        {
            f.Nome = txtNome.Text;
            f.Salario = double.Parse(txtSalario.Text);
            lblvalor.Text = "Valor das férias = "+ 
                f.Calcular(int.Parse(txtTempo.Text)).ToString();
        }

        private void btninss_Click(object sender, EventArgs e)
        {
            f.Nome = txtNome.Text;
            f.Salario = double.Parse(txtSalario.Text);
            lblvalor.Text = "Valor do INSS = " +
                f.Calcular().ToString();

        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            Vendedor v = new Vendedor();
            v.Nome = txtNome.Text;
            v.Salario = double.Parse(txtSalario.Text);
            lblvalor.Text= "Valor da comissao = "+ 
                v.Calcular(6).ToString();
        }
    }
}
