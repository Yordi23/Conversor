using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversorDecimal.Forms;

namespace ConversorDecimal
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void btnOpenAscii_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAscii formAscii = new formAscii();
            formAscii.ShowDialog();
            this.Show();
        }

        private void btnOpenSistemas_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSistemas formSistemas = new formSistemas();
            formSistemas.ShowDialog();
            this.Show();
        }
    }
}
