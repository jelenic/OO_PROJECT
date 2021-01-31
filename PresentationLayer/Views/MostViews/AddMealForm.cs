using InfrastructureLayer.DataAccess.Repositories.Specific.Meal;
using OO_PocketGourmet_REAL.Models.Meals;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.MealServices;
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
    public partial class AddMealForm : Form
    {
        private int rID;
        public AddMealForm(int id)
        {
            rID = id;
            InitializeComponent();
        }

        private void addMealBtn_Click(object sender, EventArgs e)
        {
            string mealName = nameTB.Text;
            int mealPrice = Int32.Parse(priceTB.Text);

            int salt = Int32.Parse(saltTB.Text);
            int sweet = Int32.Parse(sweetTB.Text);
            int sour = Int32.Parse(sourTB.Text);
            int spicy = Int32.Parse(spicyTB.Text);
            int bitter = Int32.Parse(bitterTB.Text);

            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            MealServices mealServices = new MealServices(new MealRepository(_connectionString), new ModelDataAnnotationCheck());
            MealModel meal = new MealModel()
            {
                MealName = mealName,
                MealPrice = mealPrice,
                MealSaltTaste = salt,
                MealSweetTaste = sweet,
                MealSourTaste = sour,
                MealSpicyTaste = spicy,
                MealBitterTaste = bitter,
                MealRestaurant = rID
                
            };
            mealServices.Add(meal);
            MessageBox.Show("Meal Added");
        }
    }
}
