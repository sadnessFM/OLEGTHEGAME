using System;
using System.Media;
using System.Windows.Forms;

namespace nynaynayyanyanynaynanyanynaynay
{
    public class FormHelper : Bebra
    {
        public static void PlaySound(string path)
        {
            SoundPlayer soundeffect = new SoundPlayer(path);
            try
            {
                soundeffect.Play();
            }
            catch (Exception e)
            {
                CatchError(e);
            }
        }

        public static void PlaySound(bool check, string path, string FailPath)
        {
            try
            {
                if (check != true)
                    PlaySound(path);

                else
                    PlaySound(FailPath);
            }
            catch (Exception e)
            {
                CatchError(e);
            }
        }

        public static void ClearTextBoxes(TextBox box1, TextBox box2)
        {
            box1.Text = "";
            box2.Text = "";
        }

        public static void CatchError(Exception e) => MessageBox.Show(Convert.ToString(e), "ERROR",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
