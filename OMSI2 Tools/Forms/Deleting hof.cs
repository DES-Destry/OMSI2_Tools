using System;
using System.Threading;
using System.Windows.Forms;
using DESTRY.IO;
using System.IO;
using OMSI2_Tools.Properties;
using System.Threading.Tasks;

namespace OMSI2_Tools.Forms
{
    public partial class Deleting_hof : Form
    {
        #region PRIVATE_FIELDS
        private readonly string PATH = "Vehicles";
        private readonly string DEL_EXT = ".hof";
        private byte state = 0;
        #endregion
        public Deleting_hof()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            OMSI omsi = new OMSI() { Opacity = 0 };
            omsi.Show();                            //Create and open new Main form of app
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                Opacity -= 0.1;
            }
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                omsi.Opacity += 0.1;
            }
            Close();
        }

        private async void Delete(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (state == 0)
                {
                    DeleteLbl.Text = "Deleting...";
                    state = 1;
                    Thread.Sleep(250);
                }
                else if (state == 1)
                {
                    DeleteLbl.Text = "Deleting";
                    state = 2;
                    Thread.Sleep(250);
                }
                else if (state == 2)
                {
                    DeleteLbl.Text = "Deleting.";
                    state = 3;
                    Thread.Sleep(250);
                }
                else if (state == 3)
                {
                    DeleteLbl.Text = "Deleting..";
                    state = 0;
                    Thread.Sleep(250);
                }

            });
            DeletingProgress.Visible = true;
            string[] dirs = Finder.FindDirectoryWhichExists(PATH, DEL_EXT);
            int size = dirs.Length;
            foreach (string dir in dirs)
            {
                string[] files = Directory.GetFiles(dir);
                DeletingProgress.Maximum = size;
                await Task.Run(() =>
                {
                    foreach (string file in files)
                    {
                        if (Path.GetExtension(file) == DEL_EXT)
                            File.Delete(file);
                    }
                    DeletingProgress.Value += 1;
                });
            }
            if (DeletingProgress.Value == size)
            {
                OMSI omsi = new OMSI() { Opacity = 0 };
                omsi.StatusLbl.Text = "Uninstalling was successful!";
                omsi.StatusPctr.Image = Resources.Success;
                omsi.Show();
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(25);
                    Opacity -= 0.1;
                }
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(25);
                    omsi.Opacity += 0.1;
                }
                Close();
            }
            else
            {
                OMSI omsi = new OMSI() { Opacity = 0 };
                omsi.StatusLbl.Text = "Something went wrong...";
                omsi.StatusPctr.Image = Resources.Wrong;
                omsi.Show();
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(25);
                    Opacity -= 0.1;
                }
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(25);
                    omsi.Opacity += 0.1;
                }
                Close();
            }
        }
    }
}