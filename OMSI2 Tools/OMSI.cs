using System;
using System.Windows.Forms;
using System.Threading;

namespace OMSI2_Tools
{
    public partial class OMSI : Form
    {
        public OMSI()
        {
            InitializeComponent();
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                Opacity -= 0.1;
            }
            Application.Exit();
        }

        private void HofChoose(object sender, EventArgs e)
        {
            Forms.HofActionChoose choose = new Forms.HofActionChoose();
            choose.Opacity = 0;
            choose.Show();
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                Opacity -= 0.1;
            }
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                choose.Opacity += 0.1;
            }
        }
    }
}
