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
using travelAworld.Model;

namespace travelAworld.WinUI.Uposlenici
{
    public partial class frmAddEditUposlenik : Form
    {
        private readonly APIService _apiService = new APIService("user/getroles");
        private readonly APIService _register = new APIService("user/register");
        private readonly APIService _getUser = new APIService("user");
        private readonly APIService _updateUser = new APIService("user/edituser");
        private readonly APIService obrisiUposlenika = new APIService("user/deleteUser");
        byte[] img = null;

        UserToRegister userToRegister = new Model.UserToRegister();

        private int? id = null;
        public frmAddEditUposlenik(int? userid = null)
        {
            InitializeComponent();
            id = userid;
            if (id.HasValue)
            {
                this.formTitle.Text = "Uredi podatke zaposlenog";
                this.FormBorderStyle = FormBorderStyle.Sizable;
                txtPassword.Enabled = false;
                btnPrebaciOglase.Visible = true;
                btnObrisi.Visible = true;
            }
            loadData();
        }

        private async void loadData()
        {

            var getRoles = _apiService.Get<List<Model.RoleToDisplay>>(null);
            dropFunkcija.DataSource = getRoles;
            dropFunkcija.DisplayMember = "RoleName";
            dropFunkcija.ValueMember = "RoleId";


            if (id.HasValue)
            {
                var korisnik = await _getUser.GetById<UsertoDisplay>(id);
                txtAdresa.Text = korisnik.Adresa;
                txtMail.Text = korisnik.Email;
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtUsername.Text = korisnik.Username;
                dropFunkcija.Text = korisnik.Role;
            }
            
        }

        private async void spasiFormu(object sender, EventArgs e)
        {
            if (!passValidation())
                return;

            //dodaj 
            if (!id.HasValue)
            {
                Model.UserToRegister userToRegister = new Model.UserToRegister
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtMail.Text,
                    Adresa = txtAdresa.Text,
                    Role = dropFunkcija.Text,
                    Dob = dateDob.Value,
                    Picture = img
                };

                await _register.Insert<Model.UsertoDisplay>(userToRegister);
                MessageBox.Show("Uspješno ste dodali uposlenika", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //edit
            else
            {
                UserToEdit user = new UserToEdit
                {
                    Adresa = txtAdresa.Text,
                    Dob = dateDob.Value,
                    Email = txtMail.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Username = txtUsername.Text,
                    Role = dropFunkcija.Text,
                    Picture = img
                };
                await _updateUser.Update<dynamic>(id.Value, user);

                MessageBox.Show("Uspješno ste promijenili podatke", "Uređivanje podataka zaposlenog", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private bool passValidation()
        {

            if (string.IsNullOrEmpty(txtIme.Text))
            {
                showMsg("Ime je Obavezno polje"); return false;
            }
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                showMsg("Prezime je Obavezno polje"); return false;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                showMsg("Korisničko ime je Obavezno polje"); return false;
            }
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                showMsg("Email je Obavezno polje"); return false;
            }
            if (string.IsNullOrEmpty(txtAdresa.Text))
            {
                showMsg("Adresa je Obavezno polje"); return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text) && id == null)
            {
                showMsg("Lozinka je Obavezno polje"); return false;
            }
            
            return true;
        }

        private void showMsg(string poruka)
        {
            MessageBox.Show(poruka, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dodajSliku(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                img = File.ReadAllBytes(fileName);
                userPicture.Text = fileName;

                Image image = Image.FromFile(fileName);
                userPicture.Image = image;
            }
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            var isDeleted = await obrisiUposlenika.Insert<bool>(id);
            if(!isDeleted)
            {
                MessageBox.Show("Uposlenika nije moguće obrisati jer ima postavljene oglase.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Uspješno ste obrisali uposlenika", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrebaciOglase_Click(object sender, EventArgs e)
        {
            frmPrebaciOglas frm = new frmPrebaciOglas(id.Value);
            frm.Show();
        }
    }
}
