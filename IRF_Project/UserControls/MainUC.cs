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
		MealDatabaseEntities1 data = new MealDatabaseEntities1();

		List<Meal> allMeals = new List<Meal>();
		List<Meal> selected = new List<Meal>();

		List<DayProgress> progressList = new List<DayProgress>();

		int allCalorie = 0;

		public MainUC()
		{
			InitializeComponent();

			var ilist = from i in data.Meals
						select i;
			allMeals = ilist.ToList();
			listBox1.DataSource = ilist.ToList();

			listBox1.DisplayMember = "Name";

			//mentéshez
			var jlist = from j in data.DayProgresses
						select j;
			progressList = jlist.ToList();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == null)
				return;

			var id = (Meal)listBox1.SelectedItem;
			selected.Add(id);
			Console.WriteLine(selected.Count);
			RefreshSelectedList();
			
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			if (listBox2.SelectedItem == null)
				return;

			var id = (Meal)listBox2.SelectedItem;
			selected.Remove(id);
			RefreshSelectedList();
			if (selected.Count > 0)
				listBox2.SelectedIndex = 0;
		}

		/// <summary>
		/// Frissíti a kiválasztott elemekből álló ListBox-ot.
		/// </summary>
		private void RefreshSelectedList()
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

			generateErrorLabel.Text = "";
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			if (listBox1.SelectedItem != null)
			{
				listBox2.ClearSelected();
				calorieLabel.Text = ((Meal)listBox1.SelectedItem).Calorie.ToString();
				mealName.Text = ((Meal)listBox1.SelectedItem).Name;
			}
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			if (listBox2.SelectedItem != null)
			{
				listBox1.ClearSelected();
				calorieLabel.Text = ((Meal)listBox2.SelectedItem).Calorie.ToString();
				mealName.Text = ((Meal)listBox2.SelectedItem).Name;
			}
		}


		///RANDOM GENERÁTOR (kifejtve a readme-ben)
		private void button1_Click(object sender, EventArgs e)
		{
			
			int cal = 0;
			int meal = 0;			
			try
			{
				cal = Int32.Parse(calorieNumeric.Text);
				meal = Int32.Parse(mealNumeric.Text);
			}
			catch
			{
				Console.WriteLine("Error");
				generateErrorLabel.Text = "Please add valid input...";
				return;
			}
			
			List<Meal> mealList = allMeals.ToList();
			List<Meal> generatedList = new List<Meal>();
			Random rnd = new Random();
			int num = 0;
			float average = 0;			

			while (meal > 0)
			{
				Console.WriteLine("generating...");
				Console.WriteLine("cal: " + cal + ", average: " + average);
				///az első étel random generálása és átlagszámítás
				if (generatedList.Count < 1)
				{
					
					num = rnd.Next(0, mealList.Count);
					average = (float)(cal- mealList[num].Calorie) / (meal-1);
				}
				else				
				{	///az átlaghoz való legközelebbi étel kiválasztása
					int selectedM = 0;
					for (int i = 1; i < mealList.Count; i++)
					{
						if (Math.Abs(average - mealList[selectedM].Calorie) > Math.Abs(average - mealList[i].Calorie))
						{
							Console.WriteLine(Math.Abs(average - mealList[selectedM].Calorie) + " > " + Math.Abs(average - mealList[i].Calorie));
							selectedM = i;
						}
					}
					num = selectedM;
				}


				///listák és váltokzók frissítése
				generatedList.Add(mealList[num]);
				meal--;
				cal -= mealList[num].Calorie;
				mealList.RemoveAt(num);
			}

			///generált lista betöltése
			selected = generatedList;
			RefreshSelectedList();
		}


		///SORTING DROPDOWN
		private void sorterDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{			
			List<Meal> newSort = new List<Meal>();			

			if (sorterDropdown.SelectedIndex == 0)
			{
				newSort = allMeals.OrderBy(x => x.Id).ToList();
			}
			else if (sorterDropdown.SelectedIndex == 1)
			{
				newSort = allMeals.OrderBy(x => x.Calorie).ToList();
			}
			else if (sorterDropdown.SelectedIndex == 2)
			{
				newSort = allMeals.OrderBy(x => x.Name).ToList();	
			}

			listBox1.DataSource = newSort;
			listBox1.DisplayMember = "Name";
			listBox1.ClearSelected();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (selected.Count == 0)
			{
				generateErrorLabel.Text = "Error: No meals selected";
				generateErrorLabel.ForeColor = Color.Red;
				return;
			}

			Console.WriteLine(progressList.Count + 1 + " " + allCalorie + " " + selected.Count);

			///létrehozunk egy új napot
			DayProgress newDay = new DayProgress(progressList.Count+1, allCalorie, selected.Count);
			
			///a kiválasztott elemek id-ját kilisitázva átadjuk
			newDay.CreateMealString((from item in selected select item.Name).ToList());
			Console.WriteLine("mealstring: " + newDay.MealString.Length + ", " + newDay.MealCount);

			///a napot hozzáadjuk a táblához
			data.DayProgresses.Add(newDay);
			data.SaveChanges();
			progressList.Add(newDay);
			selected.Clear();
			RefreshSelectedList();

			generateErrorLabel.Text = "Day saved";
			generateErrorLabel.ForeColor = Color.Green;
		}
	}
}
