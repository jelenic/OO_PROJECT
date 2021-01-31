using InfrastructureLayer.DataAccess.Repositories.Specific.Restaurant;
using OO_PocketGourmet_REAL.Models.Restourant;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.RestaurantServices;
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
    public partial class AddRestaurantForm : Form
    {
        public AddRestaurantForm()
        {
            InitializeComponent();
        }

        private void addRestaurantBtn_Click(object sender, EventArgs e)
        {
            string restaurantName = restaurantNameTB.Text;
            string restaurantAddress = restaurantAddressTB.Text;
            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            RestaurantServices restaurantServices = new RestaurantServices(new RestaurantRepository(_connectionString), new ModelDataAnnotationCheck());
            RestaurantModel restaurant = new RestaurantModel()
            {
                RestaurantName = restaurantName,
                RestaurantAddress = restaurantAddress,
            };
            restaurantServices.Add(restaurant);

            MessageBox.Show("Restaurant Added");
        }
    }
}
