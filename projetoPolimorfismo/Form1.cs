using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoPolimorfismo
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        empregado objeto = null;
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(rdbAssalariado.Checked)
            {
                objeto = new assalariado();
                double t;
                t = 0;
                lblVencimento.Text = objeto.vencimento(t).ToString();
            }
            else if(rdbComissionado.Checked)
            {
                objeto = new comissionado();
                double t;
                t = 0;
                lblVencimento.Text = objeto.vencimento(t).ToString();
            }
            else if (rdbHorista.Checked)
            {
                objeto = new horista();
                double t;
                t = 0;
                lblVencimento.Text = objeto.vencimento(t).ToString();
            }
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
