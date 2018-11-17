using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDecimal.Forms
{
    public partial class formSistemas : Form
    {
        public formSistemas()
        {
            InitializeComponent();
        }

        private void formSistemas_Load(object sender, EventArgs e)
        {
            cbmBoxFrom.SelectedIndex = 0;
            cbmBoxTo.SelectedIndex = 0;
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(txtCode.Text);
            try { 
            if (((cbmBoxFrom.SelectedIndex == 0) && (cbmBoxTo.SelectedIndex == 0)) || ((cbmBoxFrom.SelectedIndex == 1) && (cbmBoxTo.SelectedIndex == 1)) || ((cbmBoxFrom.SelectedIndex == 2) && (cbmBoxTo.SelectedIndex == 2)) || ((cbmBoxFrom.SelectedIndex == 3) && (cbmBoxTo.SelectedIndex == 3)))
            {
                txtConvert.Text = txtCode.Text;
            }
            else if ((cbmBoxFrom.SelectedIndex == 0) && (cbmBoxTo.SelectedIndex == 1))
            {
                txtConvert.Text = Convert.ToString(Convert.ToInt32(code.ToString(), 2), 8);
            }
            else if ((cbmBoxFrom.SelectedIndex == 0) && (cbmBoxTo.SelectedIndex == 2))
            {

                txtConvert.Text = Convert.ToString(Convert.ToInt32(code.ToString(), 2));
            }
            else if ((cbmBoxFrom.SelectedIndex == 0) && (cbmBoxTo.SelectedIndex == 3))
            {

                txtConvert.Text = Convert.ToString(Convert.ToInt32(code.ToString(), 2), 16);
            }
            else if ((cbmBoxFrom.SelectedIndex == 1) && (cbmBoxTo.SelectedIndex == 0))
            {
                txtConvert.Text = Convert.ToString(Convert.ToInt32(code.ToString(), 8), 2);
            }

            else if ((cbmBoxFrom.SelectedIndex == 1) && (cbmBoxTo.SelectedIndex == 2))
            {
                txtConvert.Text = Convert.ToString(Convert.ToInt32(code.ToString(), 8));
            }
            else if ((cbmBoxFrom.SelectedIndex == 1) && (cbmBoxTo.SelectedIndex == 3))
            {
                txtConvert.Text = Convert.ToString(Convert.ToInt32(code.ToString(), 8), 16).ToUpper();
            }
            else if ((cbmBoxFrom.SelectedIndex == 2) && (cbmBoxTo.SelectedIndex == 0))
            {
                txtConvert.Text = Convert.ToString(code, 2);
            }
            else if ((cbmBoxFrom.SelectedIndex == 2) && (cbmBoxTo.SelectedIndex == 1))
            {
                txtConvert.Text = Convert.ToString(code, 8);
            }
            else if ((cbmBoxFrom.SelectedIndex == 2) && (cbmBoxTo.SelectedIndex == 3))
            {
                txtConvert.Text = Convert.ToString(code, 16).ToUpper(); ;
            }

            } catch(Exception except)
            {
                MessageBox.Show(except.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        }
    }

