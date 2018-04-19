using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmPainelControle : Form
    {
        public FrmPainelControle()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtTempo.Text = txtTempo.Text + "1";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtTempo.Text = txtTempo.Text + "0";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtTempo.Text = txtTempo.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtTempo.Text = txtTempo.Text + "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtTempo.Text = txtTempo.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtTempo.Text = txtTempo.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtTempo.Text = txtTempo.Text + "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtTempo.Text = txtTempo.Text + "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtTempo.Text = txtTempo.Text + "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtTempo.Text = txtTempo.Text + "9";
        }

        public void Limpar()
        {
            txtTempo.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
