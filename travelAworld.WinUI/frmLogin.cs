using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelAworld.Model;

namespace travelAworld.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _apiService = new APIService("user/login");
        public frmLogin()
        {
            InitializeComponent();
            errorBox.Visible = false;
        }

        private async void login(object sender, EventArgs e)
        {
            UserToLogin userToLogin = new UserToLogin
            {
                Username = txtLoginUsername.Text,
                Password = txtLoginPassword.Text
            };

            APIService.Username = txtLoginUsername.Text;
            APIService.Password = txtLoginPassword.Text;

            //var result = _apiService.Login(userToLogin);
            //var result = _apiService.Insert<MyResponse>(userToLogin);
            var result = await _apiService.Insert<MyResponse>(userToLogin);

            if (result.Token != "error")
            {
                //set user properties
                Properties.Settings.Default.Token = result.Token;
                Properties.Settings.Default.UserId = result.User.Id;
                Properties.Settings.Default.Username = result.User.Username;
                Properties.Settings.Default.FirstName = result.User.Ime;
                Properties.Settings.Default.LastName = result.User.Prezime;
                Properties.Settings.Default.Role = result.User.Role;
                Properties.Settings.Default.ProfilePic = result.User.ProfilePic!=null ? System.Convert.ToBase64String(result.User.ProfilePic) : null;
                

                Properties.Settings.Default.Save();

                this.Visible = false;
                frmIndex form2 = new frmIndex();
                form2.Show();
            }
            else
            {
                errorBox.Visible = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
