using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _apiService = new APIService("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                var result = await _apiService.GetAll<List<Model.Korisnici>>();

                MDIParent1 frm = new MDIParent1();
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Pogresan username ili password");
            }
        }
    }
}
