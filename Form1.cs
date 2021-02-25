using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_ok.Enabled = false; // to make button disable
            textBox_nbr.ShortcutsEnabled = false; // to disable copy on textbox
            textBox_nbr2.ShortcutsEnabled = true;



        }

        private bool make_operation = false;
        private bool write_nbr1 = false;

        private void radioButton_Add_CheckedChanged(object sender, EventArgs e)
        {
            label_Operation.Text = "+";
            make_operation = true;
            if (write_nbr1)
                button_ok.Enabled = true;
        }

        private void radioButton_Sou_CheckedChanged(object sender, EventArgs e)
        {
            label_Operation.Text = "-";
            make_operation = true;
            if (write_nbr1)
                button_ok.Enabled = true;
        }

        private void radioButton_Mult_CheckedChanged(object sender, EventArgs e)
        {
            label_Operation.Text = "*";
            make_operation = true;
            if (write_nbr1)
                button_ok.Enabled = true;
        }

        private void radioButton_div_CheckedChanged(object sender, EventArgs e)
        {
            label_Operation.Text = "/";
            make_operation = true;
            if (write_nbr1)
                button_ok.Enabled = true;
        }

        private void radioButton_RC_CheckedChanged(object sender, EventArgs e)
        {
            label_Operation.Text = "^(1/2)";
            make_operation = true;
            if (write_nbr1)
                button_ok.Enabled = true;
            textBox_nbr2.Enabled = false;
            textBox_nbr2.Text = "0";
            
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
             int nbr1 = 0;
             int nbr2 = 0;
            if (textBox_nbr.Text != null && textBox_nbr2 != null)
            {
                 nbr1 = int.Parse(textBox_nbr.Text);
                 nbr2 = int.Parse(textBox_nbr2.Text);
            }
            else if(textBox_nbr.Text == null && textBox_nbr2 != null)
            {
                nbr1 = 0;
                nbr2 = int.Parse(textBox_nbr2.Text);

            }
            else if(textBox_nbr.Text != null && textBox_nbr2 == null)
            {
                nbr1 = int.Parse(textBox_nbr.Text);
                nbr2 = 0;
            }
            switch (label_Operation.Text)
            {
                case "+":
                    textBox_result.Text = Convert.ToString(nbr1 + nbr2);
                    break;
                case "-":
                    textBox_result.Text = Convert.ToString(nbr1 - nbr2);
                    break;
                case "*":
                    textBox_result.Text = Convert.ToString(nbr1 * nbr2);
                    break;
                case "/":
                    if(nbr2!=0)
                    textBox_result.Text = Convert.ToString((float)nbr1 / nbr2); 
                    break;
                case "^(1/2)":
                    textBox_result.Text = Convert.ToString(Math.Sqrt(nbr1));
                    break;
            }

        }

        private void textBox_nbr2_TextChanged(object sender, EventArgs e)
        {
           
            if (write_nbr1 && make_operation)
                button_ok.Enabled = true;
        }

        private void textBox_nbr_TextChanged(object sender, EventArgs e)
        {
            write_nbr1 = true;
            if (textBox_nbr != null && make_operation==true)
            {
                button_ok.Enabled = true;

            }
        }

        private void button_RMZ_Click(object sender, EventArgs e)
        {
            textBox_nbr.Text = null;
            textBox_nbr2.Text = null;
            textBox_result.Text = null;
            label_Operation.Text = null;
            button_ok.Enabled = false; 
            textBox_nbr.Focus(); // to point the cursor in textbox1 
        }

        private void textBox_nbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // to allow write but numbres 
            // if you want to allow writing but characters you to change IsDigite by IsLettre

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_nbr2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("are you sure you want exist", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
