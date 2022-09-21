using System;
using System.Media;
using System.Windows.Forms;

namespace nynaynayyanyanynaynanyanynaynay
{
    public partial class Bebra : Form
    {
        public Bebra()
        {
            InitializeComponent();
            textBox2.Text += cat.OutInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            textBox1.Text += cat.Pelmeni(5);
            PlaySimpleSound(@path2);
            textBox2.Text += cat.OutInfo();
            DeadInside();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            textBox1.Text += cat.Perekur(5);
            PlaySimpleSound(@path1);
            textBox2.Text += cat.OutInfo();
            DeadInside();
        }


        private void DeadInside()
        {
            if (cat.Check() == true)
            {
                MessageBox.Show("КОТИК УСЕРЛСЯ", "хуй", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PlaySimpleSound(path3);
            }
        }

        private void PlaySimpleSound(string path)
        {
            SoundPlayer soundeffect = new SoundPlayer(path);
            try
            {
                soundeffect.Play();
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }

        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private readonly string path1 = @"C:\Users\ArtSt\source\repos\nynaynayyanyanynaynanyanynaynay\beebe.wav";

        private readonly string path2 = @"C:\Users\ArtSt\source\repos\nynaynayyanyanynaynanyanynaynay\rehehehe.wav";

        private readonly string path3 = @"C:\Users\ArtSt\source\repos\nynaynayyanyanynaynanyanynaynay\byerk.wav";

        private readonly KOSHAK cat = new KOSHAK(14, "РУССКИЙ НАЦИОНАЛИСТ", "OLEG");
    }
}
