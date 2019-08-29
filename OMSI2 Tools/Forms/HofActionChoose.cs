using System;
using System.Threading;
using System.Windows.Forms;

namespace OMSI2_Tools.Forms
{
    public partial class HofActionChoose : Form
    {
        public HofActionChoose()
        {
            InitializeComponent();
        }

        //Close choose window
        private void CloseWindow(object sender, EventArgs e)
        {
            OMSI omsi = new OMSI() {Opacity = 0};
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

        #region Info_Label_Text
        private void InstallInfo(object sender, EventArgs e)
        {
            InfoLbl.Text = "Install *.hof files as you chose next. Only add new *.hof files.";
        }

        private void InstallInfoClear(object sender, EventArgs e)
        {
            InfoLbl.Text = "";
        }

        private void ReinstallInfo(object sender, EventArgs e)
        {
            InfoLbl.Text = "Reinstall *.hof files as you chose next. Delete your old *.hof files and install new *.hof files.";
        }

        private void ReinstallInfoClear(object sender, EventArgs e)
        {
            InfoLbl.Text = "";
        }

        private void UninstallInfo(object sender, EventArgs e)
        {
            InfoLbl.Text = "Uninstall *.hof files which you have. Delete all your old *.hof files.";
        }

        private void UninstallInfoClear(object sender, EventArgs e)
        {
            InfoLbl.Text = "";
        }
        #endregion

        private void Install(object sender, EventArgs e)
        {
            Forms.Installing_hof install = new Installing_hof() { Opacity = 0 };
            install.Show();                           
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                Opacity -= 0.1;
            }
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                install.Opacity += 0.1;
            }
            Close();
        }

        private void Unistall(object sender, EventArgs e)
        {
            Forms.Deleting_hof delete = new Deleting_hof() { Opacity = 0 };
            delete.Show();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                Opacity -= 0.1;
            }
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                delete.Opacity += 0.1;
            }
            Close();
        }

        private void Reinstall(object sender, EventArgs e)
        {
            Forms.Reinstall_hof reinstall = new Reinstall_hof() { Opacity = 0 };
            reinstall.Show();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                Opacity -= 0.1;
            }
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(25);
                reinstall.Opacity += 0.1;
            }
            Close();
        }
    }
}