using System.Windows.Forms;

namespace MegaDesk_Museruka
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MainMenu mainForm = (MainMenu)Tag;
            mainForm.Show();
            Close();
        }
    }
}
