using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using travelAworld.Model;
using Xamarin.Forms;

namespace travelAworld.MobileApp.ViewModels
{
    public class RegisterViewModel
    {
        private readonly APIService _service = new APIService("user/register");
        public ICommand RegisterCommand
        {
            get
            {
                return new Command(() =>
                {
                    var userToRegister = new UserToRegister
                    {
                        Ime = "gethtiuei",
                        Prezime = "fjiogjot",
                        Email = "jtoigo@gmail.com",
                        Username = "hutirhgiruhcrhtu",
                        Password = "testg",
                        Role = "Member"
                    };


                    var result = _service.Insert<UsertoDisplay>(userToRegister);
                });
            }
        }
    }
}
