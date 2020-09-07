using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelAworld.WinUI.Ponude;
using travelAworld.WinUI.Rezervacije;
using travelAworld.WinUI.Statistika;
using travelAworld.WinUI.Uposlenici;
using travelAworld.WinUI.Users;

namespace travelAworld.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;
        private Form activeForm = null;
        private readonly APIService _apiService = new APIService("user");
        private Helpers helpers = new Helpers();

        public frmIndex()
        {
            InitializeComponent();
            loadUserData();
            hideSubMenu();
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void loadUserData()
        {
            if (Properties.Settings.Default.Role != "Administrator")
            {
                btnUposlenici.Visible = false;
            }
            txtUserFullName.Text = Properties.Settings.Default.FirstName + " " + Properties.Settings.Default.LastName;
            txtUserRole.Text = Properties.Settings.Default.Role;
            if (Properties.Settings.Default.ProfilePic != null)
            {
                profilePic.Image = ByteToImage(System.Convert.FromBase64String(Properties.Settings.Default.ProfilePic));
            }
            else
            {
                profilePic.Image = Properties.Resources.blankPhoto;
            }
        }

        private void hideSubMenu()
        {
            panelUposleniciSubmenu.Visible = false;
            panelKorisniciSubMenu.Visible = false;
            panelPonudeSubMenu.Visible = false;

            btnPoruke.Visible = false;
            btnUplate.Visible = false;
        }

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            // Application.Exit() tells your App to close itself
            //Also if you want to be more aggressive, there is another option, you can  
            //use, Environment.Exit(1), which will basically kill you process.
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnUposlenici_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUposleniciSubmenu);
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKorisniciSubMenu);
        }

        private void btnPonude_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPonudeSubMenu);
        }

        private void btnListaKorisnika_Click(object sender, EventArgs e)
        {
            helpers.openChildFormInPanel(new frmUsers(), panelChildForm);
        }

        private void btnListaUposlenika_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmListaUposlenika());
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Properties.Settings prop = new Properties.Settings();
            prop.UserId = 0;
            prop.Token = "null";
            prop.Username = prop.FirstName = prop.LastName = prop.Role = "";

            this.Visible = false;
            frmLogin form2 = new frmLogin();
            form2.Show();
            Environment.Exit(0);
        }

        private void btnNoviUposlenik_Click(object sender, EventArgs e)
        {
            helpers.openChildFormInPanel(new frmAddEditUposlenik(), panelChildForm);
        }

        private void btnNovaPonuda_Click(object sender, EventArgs e)
        {
            helpers.openChildFormInPanel(new frmAddEditPonuda(), panelChildForm);
        }

        private void btnListaPonuda_Click(object sender, EventArgs e)
        {
            helpers.openChildFormInPanel(new frmListaPonuda(), panelChildForm);
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmListaRezervacija());
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmStatistika());
        }

    }
}
