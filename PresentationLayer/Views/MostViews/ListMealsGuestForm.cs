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
using PresentationLayer.Views.UserControls;

namespace PresentationLayer.Views.MostViews
{
    public partial class ListMealsGuestForm : Form
    {
        private List<MealModel> mealList;
        private int rID;
        public ListMealsGuestForm(int id)
        {
            InitializeComponent();
            rID = id;
            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            MealServices mealServices = new MealServices(new MealRepository(_connectionString), new ModelDataAnnotationCheck());
            mealList = (List<MealModel>)mealServices.GetAll(id);
            AddMealList(mealList);
        }

        private MealItemGuest CreateMealItem(MealModel mm)
        {
            MealItemGuest item = new MealItemGuest(mm, this);
            item.Dock = DockStyle.Top;
            return item;
        }

        public void AddMealList(List<MealModel> mealList)
        {
            var items = mealList.Select((m, index) => CreateMealItem(m)).ToArray();
            mealPanel.Controls.AddRange(items);
        }
    }
}
