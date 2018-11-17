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
    public partial class formAscii : Form
    {
        private byte value = 0; 

        public formAscii()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private bool txtValidate()
        {
            bool var = false;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCode.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor,  solo ingrese caracteres numéricos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Text = txtCode.Text.Remove(txtCode.Text.Length - 1);
                txtConvert.Text = "";
                var = true;
            }

            string value = txtCode.Text;
            if (txtCode.Text != "")

            {
                if (Int16.Parse(value) < 0)
                {
                    txtCode.Text = "";
                    txtConvert.Text = "";
                    MessageBox.Show("No se aceptan valores menores a 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var = true;
                }
                else if (Int16.Parse(value) > 127)
                {
                    txtCode.Text = "";
                    txtConvert.Text = "";
                    MessageBox.Show("No se aceptan valores mayores a 127", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var = true;
                }
                
            } else { var = true; }
            return var;
        }

        private void convertionToAscii (string code)
        {
            /*byte code2 = Convert.ToByte(code);
            char var = (char) code2 ;
            txtConvert.Text = Convert.ToString(var);*/

            byte code2 = Convert.ToByte(code);
            char[] characters = System.Text.Encoding.ASCII.GetChars(new byte[] { code2 });
            char var = characters[0];
            txtConvert.Text = Convert.ToString(var);
        }

        private void convertionToSystem(string code, KeyPressEventArgs e)
        {
            int x = e.KeyChar;
            txtConvert.Text = x.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
            if (value == 0)
            {
                value = 1;
                lbl1.Text = "Ingrese un caracter:";
                txtCode.MaxLength = 1;

            } else
            {
                lbl1.Text = "Ingrese el código ASCII:";
                value = 0;
                txtCode.MaxLength = 3;
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (value == 1)
                {
                    convertionToSystem(txtCode.Text, e);

                }
                
            

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            
            
                if (value == 0)
                {
                    if (!txtValidate())
                    {
                        convertionToAscii(txtCode.Text);
                    }
                if (txtCode.Text == "")
                {
                    txtConvert.Text = "";
                }
            }
                
            
           
        }

        private void refresh()
        {
            txtCode.Text = "";
            txtConvert.Text = "";

        }
    }
}
