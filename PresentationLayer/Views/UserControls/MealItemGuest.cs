using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OO_PocketGourmet_REAL.Models.Meals;
using PresentationLayer.Views.MostViews;

namespace PresentationLayer.Views.UserControls
{
    public partial class MealItemGuest : UserControl
    {
        private MealModel mealm;
        private ListMealsGuestForm Lmf;

        public MealItemGuest(MealModel mm, ListMealsGuestForm lmf)
        {
            InitializeComponent();
            mealm = mm;
            Lmf = lmf;
            nameL.Text = mm.MealName;
            priceL.Text = mm.MealPrice.ToString();

            sourL.Text = mm.MealSourTaste.ToString();
            saltL.Text = mm.MealSaltTaste.ToString();
            spicyL.Text = mm.MealSpicyTaste.ToString();
            bitterL.Text = mm.MealBitterTaste.ToString();
            sweetL.Text = mm.MealSweetTaste.ToString();
        }
    }
}
