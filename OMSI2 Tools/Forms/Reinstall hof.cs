using DESTRY.IO;
using OMSI2_Tools.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMSI2_Tools.Forms
{
    public partial class Reinstall_hof : Form
    {
        #region PRIVATE FIELDS
        private bool AllChecked;
        private bool OrangeBackGround = false;
        private readonly string HOF_PATH = "DHF63_7EGHO_F3245_DWKAD";
        private readonly string INSTALLING_PATH = "Vehicles";
        private readonly string HOF_EXT = ".hof";
        private readonly string BUS_EXT = ".bus";
        #endregion
        public Reinstall_hof()
        {
            InitializeComponent();
        }

        private void Exit_butt(object sender, EventArgs e)
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

        private void Add_hof(object sender, EventArgs e)
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

        private void Delete_all(object sender, EventArgs e)
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

        private void DragEnterList(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                DragAndDropLbl.Text = "Drop files here!";
            }
        }

        private void DropFiles(object sender, DragEventArgs e)
        {
            DragAndDropLbl.Text = "Drag and drop *.hof files at list to add";
            HofInstallList.BackColor = Color.White;

            string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string _object in objects)
            {
                if (File.Exists(_object) && Path.GetExtension(_object) == HOF_EXT)
                    File.Copy(_object, $@"{HOF_PATH}\{Path.GetFileName(_object)}", true);
                else if (Directory.Exists(_object))
                {
                    string[] files = Directory.GetFiles(_object);
                    foreach (string file in files)
                    {
                        if (File.Exists(file) && Path.GetExtension(file) == HOF_EXT)
                            File.Copy(file, $@"{HOF_PATH}\{Path.GetFileName(file)}", true);
                    }
                }
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

        private void DragLeaveList(object sender, EventArgs e)
        {
            DragAndDropLbl.Text = "Drag and drop *.hof files at list to add";
            HofInstallList.BackColor = Color.White;
        }

        private void Pulse(object sender, DragEventArgs e)
        {
            if (OrangeBackGround)
            {
                HofInstallList.BackColor = Color.FromArgb(255, 170, 1);
                OrangeBackGround = false;
                Thread.Sleep(500);
            }
            else
            {
                HofInstallList.BackColor = Color.White;
                OrangeBackGround = true;
                Thread.Sleep(500);
            }
        }

        private async void Reinstall(object sender, EventArgs e)
        {
            try
            {
                string[] dirs = Finder.FindDirectoryWhichExists(INSTALLING_PATH, HOF_EXT);
                string[] directories = Finder.FindDirectoryWhichExists(INSTALLING_PATH, BUS_EXT);
                List<string> files = new List<string>();
                foreach (string toadd in HofInstallList.CheckedItems)
                {
                    files.Add($@"{HOF_PATH}\{toadd}");
                }
                int size = directories.Length * files.Count + dirs.Length;
                InstallingProgress.Maximum = size;
                Size = new Size(638, 600);
                InstallingProgress.Visible = true;
                await Task.Run(() =>
                {
                    //DELETING
                    foreach (string dir in dirs)
                    {
                        InstallingProgress.Value += 1;
                        string[] filesdel = Directory.GetFiles(dir);
                        foreach (string file in filesdel)
                        {
                            if (Path.GetExtension(file) == HOF_EXT)
                                File.Delete(file);
                        }
                    }

                    //INSTALLING
                    foreach (string directory in directories)
                        foreach (string file in files)
                        {
                            try
                            {
                                File.Copy(file, $@"{directory}\{Path.GetFileName(file)}", true);
                                InstallingProgress.Value += 1;
                            }
                            catch (Exception)
                            {
                                string title = "Error!";
                                string message = "Unknown error";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                            }
                        }
                    if (InstallingProgress.Value == size)
                    {
                        OMSI omsi = new OMSI() { Opacity = 0 };
                        omsi.StatusLbl.Text = "Reinstalling was successful!";
                        omsi.StatusPctr.Image = Resources.Success;
                        omsi.Show();
                        //for (int i = 0; i < 10; i++)
                        //{
                        //    Thread.Sleep(25);
                        //    Opacity -= 0.1;
                        //}
                        //for (int i = 0; i < 10; i++)
                        //{
                        //    Thread.Sleep(25);
                        //    omsi.Opacity += 0.1;
                        //}
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
                );
            }
            catch (Exception)
            {
                string title = "Error!";
                string message = "This application need to exists in root folder of OMSI. Reinstall the OMSI2 Tools or try start this app as administrator.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }
    }
}
