using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfrastructureLayer.DataAccess.Repositories.Specific.User;
using OO_PocketGourmet_REAL.Models.User;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.UserServices;

namespace PresentationLayer.Views.MostViews
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string password = passwordTB.Text;
            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            UserServices userServices = new UserServices(new UserRepository(_connectionString), new ModelDataAnnotationCheck());
            UserModel user = userServices.GetByEmail(username);
            if (user.UserRestaurant == 0 && password == user.UserPassword)
            {
                var frm = new AdminForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
            else if(password == user.UserPassword && user.UserRestaurant != 0)
            {
                var frm = new UserForm(user.UserRestaurant);
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }


        }
    }
}
