using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MegaDesk_Museruka
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainForm = (MainMenu)Tag;
            mainForm.Show();
            Close();

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }    

        private void widthInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(widthInput.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MINWIDTH + " to " + Desk.MAXWIDTH + " inches");
                    widthInput.Text = String.Empty;
                    widthInput.BackColor = Color.OrangeRed;
                    widthInput.Focus();
                }
            }
            else if (int.TryParse(widthInput.Text, out WidthInput) == false && widthInput.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                widthInput.Text = String.Empty;
                widthInput.BackColor = Color.OrangeRed;
                widthInput.Focus();
            }
        }

        private void depthInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(depthInput.Text, out int DepthInput) == true)
            {
                if (DepthInput < Desk.MINWIDTH || DepthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MINWIDTH + " to " + Desk.MAXWIDTH + " inches");
                    depthInput.Text = String.Empty;
                    depthInput.BackColor = Color.DarkOrange;
                    depthInput.Focus();
                }
            }
            else if (int.TryParse(depthInput.Text, out DepthInput) == false && depthInput.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                depthInput.Text = String.Empty;
                depthInput.BackColor = Color.DarkOrange;
                depthInput.Focus();
            }
        }

        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please enter a number");
                e.Handled = true;
                depthInput.BackColor = Color.DarkOrange;
                depthInput.Focus();
            }
            else
            {
                depthInput.BackColor = System.Drawing.SystemColors.Window;
            }
        }
    }
}
