using System.Windows.Forms;

namespace MegaDesk_Museruka
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        } 

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            MainMenu mainForm = (MainMenu)Tag;
            mainForm.Show();
            Close();
        }

      
    }
}
