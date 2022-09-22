using System;
using System.Windows.Forms;

namespace nynaynayyanyanynaynanyanynaynay
{
    public partial class Bebra : Form
    {
        public Bebra()
        {
            InitializeComponent();
            UpdateOLEG();
            textBox1.Text += "ЛЕВАЯ КОРМИТЬ ПРАВАЯ БИТЬ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            textBox1.Text += cat.Pelmeni(5);
            UpdateOLEG();

            if (Checked != true)
                FormHelper.PlaySound(Checked, @"C:\Users\ArtSt\source\repos\nynaynayyanyanynaynanyanynaynay\dobavka.wav", path);

            DeadInside();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            textBox1.Text += cat.Perekur(5);
            UpdateOLEG();

            FormHelper.PlaySound(Checked, @"C:\Users\ArtSt\source\repos\nynaynayyanyanynaynanyanynaynay\net.wav", path);

            DeadInside();
        }



        public void DeadInside()
        {
            if (cat.Check() == true && Checked == false)
            {
                FormHelper.PlaySound(path);
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                MessageBox.Show("КОТИК УСЕРЛСЯ", "хуй", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Value = 100 - 7;
                Checked = true;
            }
        }

        public void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        public void UpdateOLEG()
        {
            progressBar1.Value = cat.GetWeight();
            textBox2.Text += cat.OutInfo();
        }

        private readonly string path = @"C:\Users\ArtSt\source\repos\nynaynayyanyanynaynanyanynaynay\byerk.wav";

        private bool Checked = false;

        private readonly KOSHAK cat = new KOSHAK(14, "РУССКИЙ НАЦИОНАЛИСТ", "OLEG");
    }
}
