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
using ServiceLayer.Services.MealServices;
using InfrastructureLayer.DataAccess.Repositories.Specific.Meal;
using ServiceLayer.CommonServices;

namespace PresentationLayer.Views.UserControls
{
    public partial class MealItem : UserControl
    {

        private MealModel mealm;
        private ListMealsForm Lmf;
        public MealItem(MealModel mm, ListMealsForm lmf)
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            MealServices mealServices = new MealServices(new MealRepository(_connectionString), new ModelDataAnnotationCheck());
            mealServices.Delete(mealm);
            Lmf.Reload();
        }
    }
}
