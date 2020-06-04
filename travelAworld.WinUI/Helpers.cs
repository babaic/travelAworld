using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelAworld.WinUI
{
    public class Helpers
    {
        private Form activeForm = null;
        public void openChildFormInPanel(Form childForm, Control control)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            control.Controls.Add(childForm);
            control.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private string someVariable;
    }
}
