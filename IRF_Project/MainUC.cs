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
			ShowSelected();
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			var id = (Meal)listBox2.SelectedItem;
			selected.Remove(id);
			ShowSelected();
			if (selected.Count > 0)
				listBox2.SelectedIndex = 0;
		}

		void ShowSelected()
		{
			listBox2.DataSource = null;
			listBox2.DataSource = selected;
			listBox2.DisplayMember = "Name";
			listBox2.ClearSelected();
		}
	}
}
