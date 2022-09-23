using System;
using System.Windows.Forms;

namespace nynaynayyanyanynaynanyanynaynay
{
    public partial class CREATE : Form
    {
        public CREATE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SetName(textBox1.Text);
                SetAge(textBox2.Text);
                SetGender(textBox3.Text);
            }

            catch (Exception error)
            {
                FormHelper.CatchError(error);
            }
            Close();
        }

        private string SetName(string s) => ControlID.catName = s;
        private int SetAge(string s) => ControlID.catAge = Convert.ToInt32(s);
        private string SetGender(string s) => ControlID.catGender = s;

    }

    public class ControlID
    {
        public static string catName { get; set; }

        public static int catAge { get; set; }

        public static string catGender { get; set; }
    }
}
