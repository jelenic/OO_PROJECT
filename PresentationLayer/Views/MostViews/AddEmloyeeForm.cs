using InfrastructureLayer.DataAccess.Repositories.Specific.User;
using OO_PocketGourmet_REAL.Models.User;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.UserServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views.MostViews
{
    public partial class AddEmloyeeForm : Form
    {
        private int restaurantID;
        public AddEmloyeeForm(int id)
        {
            restaurantID = id;
            InitializeComponent();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            string userEmail = emailTB.Text;
            string userName = nameTB.Text;
            string userPassword = passwordTB.Text;
            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            UserServices userServices = new UserServices(new UserRepository(_connectionString), new ModelDataAnnotationCheck());
            UserModel user = new UserModel()
            {
                UserEmail = userEmail,
                UserName = userName,
                UserPassword = userPassword,
                UserRestaurant = restaurantID
            };
            userServices.Add(user);

            MessageBox.Show("User Added");
        }
    }
}
