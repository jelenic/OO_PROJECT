using InfrastructureLayer.DataAccess.Repositories.Specific.Restaurant;
using OO_PocketGourmet_REAL.Models.Restourant;
using PresentationLayer.Views.UserControls;
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
    public partial class ListRestaurantsForm : Form
    {
        private List<RestaurantModel> restaurantList;
        public ListRestaurantsForm()
        {
            InitializeComponent();
            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            RestaurantServices restaurantServices = new RestaurantServices(new RestaurantRepository(_connectionString), new ModelDataAnnotationCheck());
            restaurantList = (List<RestaurantModel>)restaurantServices.GetAll();
            AddRestaurantList(restaurantList);
        }

        private RestaurantItem CreateRestaurantItem(RestaurantModel rm)
        {
            RestaurantItem item = new RestaurantItem(rm, this);
            item.Dock = DockStyle.Top;
            return item;
        }

        public void AddRestaurantList(List<RestaurantModel> restaurantList)
        {
            var items = restaurantList.Select((m, index) => CreateRestaurantItem(m)).ToArray();
            restaurantPanel.Controls.AddRange(items);
        }

        public void Reload()
        {
            restaurantPanel.Controls.Clear();
            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            RestaurantServices restaurantServices = new RestaurantServices(new RestaurantRepository(_connectionString), new ModelDataAnnotationCheck());
            restaurantList = (List<RestaurantModel>)restaurantServices.GetAll();
            AddRestaurantList(restaurantList);
        }
    }
}
