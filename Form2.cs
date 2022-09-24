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
            ControlID.catName = textBox1.Text;
            //TODO: вместо этой хуиты сделать проверку на число в боксах
            try
            {
                ControlID.catAge = Convert.ToInt32(textBox2.Text);
            }
            catch(Exception error)
            {
                FormHelper.CatchError(error);
            }
            ControlID.catGender = textBox3.Text;

            Close();
        }
    }

    public class ControlID
    {
        public static string catName { get; set; }

        public static int catAge { get; set; }

        public static string catGender { get; set; }
    }
}
