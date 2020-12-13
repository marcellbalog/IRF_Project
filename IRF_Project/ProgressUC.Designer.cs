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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.progressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.progressChart)).BeginInit();
			this.SuspendLayout();
			// 
			// progressChart
			// 
			chartArea1.Name = "ChartArea1";
			this.progressChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.progressChart.Legends.Add(legend1);
			this.progressChart.Location = new System.Drawing.Point(33, 62);
			this.progressChart.Name = "progressChart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.progressChart.Series.Add(series1);
			this.progressChart.Size = new System.Drawing.Size(523, 300);
			this.progressChart.TabIndex = 0;
			this.progressChart.Text = "chart1";
			// 
			// ProgressUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.progressChart);
			this.Name = "ProgressUC";
			this.Size = new System.Drawing.Size(691, 439);
			((System.ComponentModel.ISupportInitialize)(this.progressChart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart progressChart;
	}
}
