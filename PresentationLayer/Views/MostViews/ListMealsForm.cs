using InfrastructureLayer.DataAccess.Repositories.Specific.Meal;
using OO_PocketGourmet_REAL.Models.Meals;
using PresentationLayer.Views.UserControls;
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
    public partial class ListMealsForm : Form
    {
        private List<MealModel> mealList;
        private int rID;
        public ListMealsForm(int id)
        {
            InitializeComponent();
            rID = id;
            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            MealServices mealServices = new MealServices(new MealRepository(_connectionString), new ModelDataAnnotationCheck());
            mealList = (List<MealModel>)mealServices.GetAll(id);
            AddMealList(mealList);
        }

        private MealItem CreateMealItem(MealModel mm)
        {
            MealItem item = new MealItem(mm, this);
            item.Dock = DockStyle.Top;
            return item;
        }

        public void AddMealList(List<MealModel> mealList)
        {
            var items = mealList.Select((m, index) => CreateMealItem(m)).ToArray();
            mealPanel.Controls.AddRange(items);
        }

        public void Reload()
        {
            mealPanel.Controls.Clear();
            string _connectionString = "Data Source=" +
               Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            MealServices mealServices = new MealServices(new MealRepository(_connectionString), new ModelDataAnnotationCheck());
            mealList = (List<MealModel>)mealServices.GetAll(rID);
            AddMealList(mealList);
        }
    }
}
