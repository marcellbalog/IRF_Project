using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IRF_Project
{
	public partial class ProgressUC : UserControl
	{
		List<DayProgress> days = new List<DayProgress>();

		public ProgressUC()
		{
			InitializeComponent();

			MealDatabaseEntities1 data = new MealDatabaseEntities1();

			var ilist = from i in data.DayProgresses
						select i;
			days = ilist.ToList();

			DrawDiagram();

			dataGridView1.DataSource = days;
			dataGridView1.Columns[0].HeaderCell.Value = "Day";
			dataGridView1.Columns[2].HeaderCell.Value = "Number of meals";
			dataGridView1.Columns[3].HeaderCell.Value = "Meals";
			dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			
		}
	
		void DrawDiagram()
		{
			progressChart.DataSource = days;

			var series = progressChart.Series[0];
			series.ChartType = SeriesChartType.Line;
			series.XValueMember = "Id";
			series.YValueMembers = "Calorie";
			series.BorderWidth = 2;

			var legend = progressChart.Legends[0];
			legend.Enabled = false;			

			var chartArea = progressChart.ChartAreas[0];
			chartArea.AxisX.MajorGrid.Enabled = true;
			chartArea.AxisY.MajorGrid.Enabled = true;
			chartArea.AxisY.IsStartedFromZero = false;
			chartArea.AxisX.Title = "Day";
			chartArea.AxisY.Title = "Calorie";
		}
	}
}
