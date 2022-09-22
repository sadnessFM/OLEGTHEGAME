using System;
using System.Media;
using System.Windows.Forms;

namespace nynaynayyanyanynaynanyanynaynay
{
    internal class FormHelper
    {
        public static void PlaySimpleSound(string path)
        {
            SoundPlayer soundeffect = new SoundPlayer(path);
            try 
            { 
                soundeffect.Play(); 
            }

            catch (Exception e) 
            { 
                MessageBox.Show(Convert.ToString(e), "error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        
        public void PlaySound(bool check, string path,string FailPath)
        {
            if (check != true)
                FormHelper.PlaySimpleSound(path);

            else
                FormHelper.PlaySimpleSound(FailPath);
        }

        /*
        public void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

            if(Checked != true)
                FormHelper.PlaySimpleSound(@path1);
        */
    }
}
