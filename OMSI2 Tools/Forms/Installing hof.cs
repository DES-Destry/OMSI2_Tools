using DESTRY.IO;
using OMSI2_Tools.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMSI2_Tools.Forms
{
    public partial class Installing_hof : Form
    {
        private bool AllChecked;
        private string HOF_PATH = "DHF63_7EGHO_F3245_DWKAD";
        private string INSTALLING_PATH = "Vehicles";
        private string HOF_EXT = ".hof";
        private string BUS_EXT = ".bus";
        public Installing_hof()
        {
            InitializeComponent();
        }

        private void ExitButt_Click(object sender, EventArgs e)
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

        private void LoadHofs(object sender, EventArgs e)
        {
            HofInstallList.CheckOnClick = true;
            Update(null, null);
            AllChecked = true;
        }

        private void Select_all(object sender, EventArgs e)
        {
            if (!AllChecked)
            {
                SelectAllButt.Text = "Uncheck all";
                SelectAllButt.Image = Resources.Uncheck_All;
                AllChecked = true;
                for (int index = 0; index < HofInstallList.Items.Count; index++)
                    HofInstallList.SetItemChecked(index, true);

            }
            else
            {
                SelectAllButt.Text = "Check all";
                SelectAllButt.Image = Resources.Check_All;
                AllChecked = false;
                for (int index = 0; index < HofInstallList.Items.Count; index++)
                    HofInstallList.SetItemChecked(index, false);
            }
        }

        private void Changed(object sender, EventArgs e)
        {
            if (HofInstallList.CheckedItems.Count == HofInstallList.Items.Count)
            {
                SelectAllButt.Text = "Uncheck all";
                SelectAllButt.Image = Resources.Uncheck_All;
                AllChecked = true;
            }
            else
            {
                SelectAllButt.Text = "Check all";
                SelectAllButt.Image = Resources.Check_All;
                AllChecked = false;
            }
        }

        private void Add_Hof(object sender, EventArgs e)
        {
            OpenFileDialog newhof = new OpenFileDialog()
            {
                Filter = "HOF Files(*.hof) | *.hof",
                CheckFileExists = true,
                RestoreDirectory = true,
                AutoUpgradeEnabled = true,
                Title = "Choose HOF files"
            };
            if (newhof.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in newhof.FileNames)
                {
                    if (File.Exists(file) && Path.GetExtension(file) == HOF_EXT)
                        File.Copy(file, $@"{HOF_PATH}\{Path.GetFileName(file)}", true);
                }
                Update(null, null);
            }
        }

        private void Update(object sender, EventArgs e)
        {
            HofInstallList.Items.Clear();
            string[] Files = Directory.GetFiles(HOF_PATH);
            string[] HOFS = Files.Where(HOF => Path.GetExtension(HOF) == HOF_EXT).ToArray();
            foreach (string HOF in HOFS)
                HofInstallList.Items.Add(HOF.Replace($@"{HOF_PATH}\", @""), true);
        }
        private void Delete(object sender, EventArgs e)
        {
            try
            {
                string name = HofInstallList.SelectedItem.ToString();
                File.Delete($@"{HOF_PATH}\{name}");
            }
            catch
            {
                string title = "Warning!";
                string message = "You need select item for delete!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
            finally
            {
                Update(null, null);
            }
        }

        private void Delete_All(object sender, EventArgs e)
        {
            try
            {
                foreach (string deleting in Directory.GetFiles(HOF_PATH))
                    if (File.Exists(deleting))
                        File.Delete(deleting);
            }
            catch
            {
                string title = "Error!";
                string message = "Unknown error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            finally
            {
                Update(null, null);
            }
        }

        private void WhiteImage(object sender, EventArgs e)
        {
            if (AllChecked)
            {
                SelectAllButt.Image = Resources.Uncheck_All_Mouse_Hover;
            }
        }

        private void StockImage(object sender, EventArgs e)
        {
            if (AllChecked)
            {
                SelectAllButt.Image = Resources.Uncheck_All;
            }
        }

        private void DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                DragAndDropLbl.Text = "Drop files here!";
            }
        }

        private void DragLeave(object sender, EventArgs e)
        {
            DragAndDropLbl.Text = "Drag and drop *.hof files at list to add";
        }

        private void DropFiles(object sender, DragEventArgs e)
        {
            DragAndDropLbl.Text = "Drag and drop *.hof files at list to add";

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (File.Exists(file) && Path.GetExtension(file) == HOF_EXT)
                    File.Copy(file, $@"{HOF_PATH}\{Path.GetFileName(file)}", true);
                else
                {
                    string title = "Error";
                    string message = "This in not a *.hof file!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
            Update(null, null);
        }

        private async void Install(object sender, EventArgs e)
        {
            try
            {
                string[] directories = Finder.FindDirectoryWhichExists(INSTALLING_PATH, BUS_EXT);
                List<string> files = new List<string>();
                foreach (string toadd in HofInstallList.CheckedItems)
                {
                    files.Add($@"{HOF_PATH}\{toadd}");
                }
                int size = directories.Length * files.Count;
                InstallingProgress.Visible = true;
                InstallingProgress.Maximum = size;
                Size = new System.Drawing.Size(638, 600);
                foreach (string directory in directories)
                    foreach (string file in files)
                    {
                        try
                        {
                            await Task.Run(() =>
                            {
                                File.Copy(file, $@"{directory}\{Path.GetFileName(file)}", true);
                                InstallingProgress.Value += 1; 
                            });
                        }
                        catch(Exception)
                        {
                            string title = "Error!";
                            string message = "Unknown error";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                        }
                    }
            }
            catch(Exception)
            {
                string title = "Error!";
                string message = "This application need to exists in root folder of OMSI. Reinstall the OMSI2 Tools or try start this app as administrator.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            finally
            {
                Size = new System.Drawing.Size(638, 560);
                InstallingProgress.Visible = false;
                InstallingProgress.Value = 0;
            }
        }
    }
}