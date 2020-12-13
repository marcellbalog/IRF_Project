namespace IRF_Project
{
	partial class ProgressUC
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.progressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.mealDatabaseDataSet = new IRF_Project.MealDatabaseDataSet();
			this.mealDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mealDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.progressChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSetBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// progressChart
			// 
			this.progressChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.progressChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.progressChart.Legends.Add(legend1);
			this.progressChart.Location = new System.Drawing.Point(18, 16);
			this.progressChart.Name = "progressChart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.progressChart.Series.Add(series1);
			this.progressChart.Size = new System.Drawing.Size(610, 240);
			this.progressChart.TabIndex = 0;
			this.progressChart.Text = "chart1";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(18, 270);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(610, 148);
			this.dataGridView1.TabIndex = 1;
			// 
			// mealDatabaseDataSet
			// 
			this.mealDatabaseDataSet.DataSetName = "MealDatabaseDataSet";
			this.mealDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// mealDatabaseDataSetBindingSource
			// 
			this.mealDatabaseDataSetBindingSource.DataSource = this.mealDatabaseDataSet;
			this.mealDatabaseDataSetBindingSource.Position = 0;
			// 
			// mealDatabaseDataSetBindingSource1
			// 
			this.mealDatabaseDataSetBindingSource1.DataSource = this.mealDatabaseDataSet;
			this.mealDatabaseDataSetBindingSource1.Position = 0;
			// 
			// ProgressUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.progressChart);
			this.Name = "ProgressUC";
			this.Size = new System.Drawing.Size(654, 439);
			((System.ComponentModel.ISupportInitialize)(this.progressChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSetBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart progressChart;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource mealDatabaseDataSetBindingSource;
		private MealDatabaseDataSet mealDatabaseDataSet;
		private System.Windows.Forms.BindingSource mealDatabaseDataSetBindingSource1;
	}
}
