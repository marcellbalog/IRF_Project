using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project.UserControls
{
	public partial class MealTableUC : UserControl
	{

		MealDatabaseEntities1 data = new MealDatabaseEntities1();
		List<Meal> meals = new List<Meal>();

		public MealTableUC()
		{
			InitializeComponent();

			var ilist = from i in data.Meals
						select i;
			meals = ilist.ToList();

			dataGridView1.DataSource = meals;
			//bindingNavigator1.BindingSource.Add(dataGridView1.DataBindings);			

		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			try
			{
				data.SaveChanges();
				errorLabel.Visible = false;
			}
			catch
			{
				errorLabel.Visible = true;
			}
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			meals.Add(new Meal());
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = meals;
		}
	}
}
