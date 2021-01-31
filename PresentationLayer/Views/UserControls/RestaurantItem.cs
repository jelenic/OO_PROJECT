using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer.Services.RestaurantServices;
using InfrastructureLayer.DataAccess.Repositories.Specific.Restaurant;
using ServiceLayer.CommonServices;
using OO_PocketGourmet_REAL.Models.Restourant;
using PresentationLayer.Views.MostViews;

namespace PresentationLayer.Views.UserControls
{
    public partial class RestaurantItem : UserControl
    {
        private RestaurantModel resm;
        private ListRestaurantsForm Lrf;
        public RestaurantItem(RestaurantModel rm, ListRestaurantsForm lrf)
        {
            /*Console.WriteLine("--------------STVARI---------------");
            Console.WriteLine(rm.ToString());
            Console.WriteLine(rm.RestaurantName);
            Console.WriteLine(rm.RestaurantAddress);
            Console.WriteLine(rm.RestaurantID);
            Console.WriteLine("--------------STVARI---------------");*/
            resm = rm;
            Lrf = lrf;
            InitializeComponent();
            restaurantNameTB.Text = rm.RestaurantName.ToString();
            restaurantAddressTB.Text = rm.RestaurantAddress.ToString();
        }

        private void removeRestaurantBtn_Click(object sender, EventArgs e)
        {
            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            RestaurantServices restaurantServices = new RestaurantServices(new RestaurantRepository(_connectionString), new ModelDataAnnotationCheck());
            restaurantServices.Delete(resm);
            Lrf.Reload();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            var frm = new AddEmloyeeForm(resm.RestaurantID);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
