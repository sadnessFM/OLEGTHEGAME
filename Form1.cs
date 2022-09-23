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
            FormHelper.ClearTextBoxes(textBox1, textBox2);
            textBox1.Text += cat.Pelmeni(50);
            UpdateOLEG();

            if (Checked != true)
                FormHelper.PlaySound(Checked, 
                    @"C:\Users\ArtSt\source\repos\nynaynayyanyanynaynanyanynaynay\picsounds\dobavka.wav", path);

            DeadInside();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormHelper.ClearTextBoxes(textBox1, textBox2);
            textBox1.Text += cat.Perekur(50);
            UpdateOLEG();

            if (Checked != true)
                FormHelper.PlaySound(Checked, 
                    @"C:\Users\ArtSt\source\repos\nynaynayyanyanynaynanyanynaynay\picsounds\net.wav", path);

            DeadInside();
        }

        private void GAME_Click(object sender, EventArgs e)
        {
            //using (CREATE sec = new CREATE())
            //{
            //
            //}
        }




        public void DeadInside()
        {
            if (cat.Check() == true && Checked == false)
            {
                FormHelper.PlaySound(path);
                pictureBox1.Dispose();
                pictureBox2.Visible = true;
                MessageBox.Show("КОТИК УСЕРЛСЯ", "хуй", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Value = (1000 - 7)/10 ;
                Checked = true;
            }
        }

        private void UpdateOLEG()
        {
            progressBar1.Value = cat.Weight/10;
            textBox2.Text += cat.OutInfo();
        }

        private readonly string path = @"C:\Users\ArtSt\source\repos\nynaynayyanyanynaynanyanynaynay\picsounds\byerk.wav";

        private bool Checked = false;

        private readonly KOSHAK cat = new KOSHAK(ControlID.catAge, ControlID.catGender, ControlID.catName);

    }
}
