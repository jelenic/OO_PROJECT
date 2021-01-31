using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OO_PocketGourmet_REAL.Models.Restourant;
using PresentationLayer.Views.MostViews;

namespace PresentationLayer.Views.UserControls
{
    public partial class RestaurantItemGuest : UserControl
    {

        private RestaurantModel resm;
        private ListRestaurantsGuestForm Lrf;
        public RestaurantItemGuest(RestaurantModel rm, ListRestaurantsGuestForm lrf)
        {
            resm = rm;
            Lrf = lrf;
            InitializeComponent();
            restaurantNameTB.Text = rm.RestaurantName.ToString();
            restaurantAddressTB.Text = rm.RestaurantAddress.ToString();
        }

        private void listMealsBtn_Click(object sender, EventArgs e)
        {
            var frm = new ListMealsGuestForm(resm.RestaurantID);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
