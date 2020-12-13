namespace IRF_Project
{
	partial class MainUC
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.removeButton = new System.Windows.Forms.Button();
			this.calorieLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.allCalorieLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.saveButton = new System.Windows.Forms.Button();
			this.calorieNumeric = new System.Windows.Forms.NumericUpDown();
			this.mealNumeric = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.generateErrorLabel = new System.Windows.Forms.Label();
			this.sorterDropdown = new System.Windows.Forms.ComboBox();
			this.mealName = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.calorieNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mealNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(37, 51);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(150, 244);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(32, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Meals";
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(100, 308);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(87, 22);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// listBox2
			// 
			this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 16;
			this.listBox2.Location = new System.Drawing.Point(225, 82);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(150, 212);
			this.listBox2.TabIndex = 3;
			this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(221, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Selected";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(434, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Calorie:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(434, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Protein:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(434, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Carbs:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(433, 274);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "All calorie:";
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(225, 308);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(87, 22);
			this.removeButton.TabIndex = 9;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// calorieLabel
			// 
			this.calorieLabel.AutoSize = true;
			this.calorieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.calorieLabel.Location = new System.Drawing.Point(496, 113);
			this.calorieLabel.Name = "calorieLabel";
			this.calorieLabel.Size = new System.Drawing.Size(16, 17);
			this.calorieLabel.TabIndex = 10;
			this.calorieLabel.Text = "0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(37, 53);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 22);
			this.button1.TabIndex = 11;
			this.button1.Text = "Generate random";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// allCalorieLabel
			// 
			this.allCalorieLabel.AutoSize = true;
			this.allCalorieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.allCalorieLabel.Location = new System.Drawing.Point(519, 274);
			this.allCalorieLabel.Name = "allCalorieLabel";
			this.allCalorieLabel.Size = new System.Drawing.Size(18, 20);
			this.allCalorieLabel.TabIndex = 12;
			this.allCalorieLabel.Text = "0";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.OldLace;
			this.panel1.Controls.Add(this.saveButton);
			this.panel1.Controls.Add(this.calorieNumeric);
			this.panel1.Controls.Add(this.mealNumeric);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.generateErrorLabel);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 348);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(638, 87);
			this.panel1.TabIndex = 13;
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.saveButton.ForeColor = System.Drawing.Color.OliveDrab;
			this.saveButton.Location = new System.Drawing.Point(535, 16);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(85, 59);
			this.saveButton.TabIndex = 19;
			this.saveButton.Text = "Save Day";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// calorieNumeric
			// 
			this.calorieNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.calorieNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.calorieNumeric.Location = new System.Drawing.Point(40, 21);
			this.calorieNumeric.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.calorieNumeric.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.calorieNumeric.Name = "calorieNumeric";
			this.calorieNumeric.Size = new System.Drawing.Size(74, 23);
			this.calorieNumeric.TabIndex = 18;
			this.calorieNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.calorieNumeric.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
			// 
			// mealNumeric
			// 
			this.mealNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mealNumeric.Location = new System.Drawing.Point(130, 21);
			this.mealNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.mealNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.mealNumeric.Name = "mealNumeric";
			this.mealNumeric.Size = new System.Drawing.Size(56, 23);
			this.mealNumeric.TabIndex = 17;
			this.mealNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mealNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(127, 5);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Meal count";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(37, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Desired calorie";
			// 
			// generateErrorLabel
			// 
			this.generateErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.generateErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.generateErrorLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.generateErrorLabel.Location = new System.Drawing.Point(360, 58);
			this.generateErrorLabel.Name = "generateErrorLabel";
			this.generateErrorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.generateErrorLabel.Size = new System.Drawing.Size(172, 13);
			this.generateErrorLabel.TabIndex = 12;
			this.generateErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// sorterDropdown
			// 
			this.sorterDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sorterDropdown.Items.AddRange(new object[] {
            "ID",
            "Calorie",
            "Name"});
			this.sorterDropdown.Location = new System.Drawing.Point(130, 24);
			this.sorterDropdown.MaxDropDownItems = 3;
			this.sorterDropdown.Name = "sorterDropdown";
			this.sorterDropdown.Size = new System.Drawing.Size(57, 21);
			this.sorterDropdown.TabIndex = 14;
			this.sorterDropdown.SelectedIndexChanged += new System.EventHandler(this.sorterDropdown_SelectedIndexChanged);
			// 
			// mealName
			// 
			this.mealName.AutoSize = true;
			this.mealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mealName.Location = new System.Drawing.Point(435, 82);
			this.mealName.Name = "mealName";
			this.mealName.Size = new System.Drawing.Size(60, 18);
			this.mealName.TabIndex = 15;
			this.mealName.Text = "Name...";
			// 
			// MainUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mealName);
			this.Controls.Add(this.sorterDropdown);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.allCalorieLabel);
			this.Controls.Add(this.calorieLabel);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Name = "MainUC";
			this.Size = new System.Drawing.Size(639, 436);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.calorieNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mealNumeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Label calorieLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label allCalorieLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label generateErrorLabel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox sorterDropdown;
		private System.Windows.Forms.Label mealName;
		private System.Windows.Forms.NumericUpDown mealNumeric;
		private System.Windows.Forms.NumericUpDown calorieNumeric;
		private System.Windows.Forms.Button saveButton;
	}
}
