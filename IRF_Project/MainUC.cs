using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
	public partial class MainUC : UserControl
	{
		MealDatabaseEntities data = new MealDatabaseEntities();

		List<Meal> selected = new List<Meal>();
		int allCalorie = 0;

		public MainUC()
		{
			InitializeComponent();

			var ilist = from i in data.Meals
						select i;
			listBox1.DataSource = ilist.ToList();

			listBox1.DisplayMember = "Name";
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var id = (Meal)listBox1.SelectedItem;
			selected.Add(id);
			Console.WriteLine(selected.Count);
			RefreshSelectedList();
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			var id = (Meal)listBox2.SelectedItem;
			selected.Remove(id);
			RefreshSelectedList();
			if (selected.Count > 0)
				listBox2.SelectedIndex = 0;
		}

		void RefreshSelectedList()
		{
			listBox2.DataSource = null;
			listBox2.DataSource = selected;
			listBox2.DisplayMember = "Name";
			listBox2.ClearSelected();

			allCalorie = 0;
			for (int i = 0; i < selected.Count; i++)
			{
				allCalorie += selected[i].Calorie;
			}
			allCalorieLabel.Text = allCalorie.ToString();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			if (listBox1.SelectedItem != null)
			{
				listBox2.ClearSelected();
				calorieLabel.Text = ((Meal)listBox1.SelectedItem).Calorie.ToString();
			}
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			if (listBox2.SelectedItem != null)
			{
				listBox1.ClearSelected();
				calorieLabel.Text = ((Meal)listBox2.SelectedItem).Calorie.ToString();
			}
		}
	}
}
