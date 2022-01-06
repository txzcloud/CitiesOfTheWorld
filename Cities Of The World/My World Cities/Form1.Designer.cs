namespace World_Cities
{
	partial class Form_worldCities
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_City = new System.Windows.Forms.Label();
            this.label_CountryText = new System.Windows.Forms.Label();
            this.label_PopulationText = new System.Windows.Forms.Label();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.label_Population = new System.Windows.Forms.Label();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.countryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countryChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(230, 20);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(35, 17);
            this.label_City.TabIndex = 1;
            this.label_City.Text = "City";
            // 
            // label_CountryText
            // 
            this.label_CountryText.AutoSize = true;
            this.label_CountryText.Location = new System.Drawing.Point(519, 20);
            this.label_CountryText.Name = "label_CountryText";
            this.label_CountryText.Size = new System.Drawing.Size(64, 17);
            this.label_CountryText.TabIndex = 2;
            this.label_CountryText.Text = "Country";
            // 
            // label_PopulationText
            // 
            this.label_PopulationText.AutoSize = true;
            this.label_PopulationText.Location = new System.Drawing.Point(808, 20);
            this.label_PopulationText.Name = "label_PopulationText";
            this.label_PopulationText.Size = new System.Drawing.Size(85, 17);
            this.label_PopulationText.TabIndex = 3;
            this.label_PopulationText.Text = "Population";
            // 
            // comboBox_City
            // 
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(132, 54);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(241, 25);
            this.comboBox_City.TabIndex = 1;
            this.comboBox_City.SelectionChangeCommitted += new System.EventHandler(this.comboBox_City_SelectionChangeCommitted);
            // 
            // label_Population
            // 
            this.label_Population.AutoSize = true;
            this.label_Population.Location = new System.Drawing.Point(808, 62);
            this.label_Population.Name = "label_Population";
            this.label_Population.Size = new System.Drawing.Size(142, 17);
            this.label_Population.TabIndex = 4;
            this.label_Population.Text = "0                         ";
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(438, 54);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(244, 25);
            this.comboBox_Country.TabIndex = 8;
            this.comboBox_Country.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Country_SelectionChangeCommitted);
            // 
            // countryChart
            // 
            chartArea2.Name = "ChartArea1";
            this.countryChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.countryChart.Legends.Add(legend2);
            this.countryChart.Location = new System.Drawing.Point(12, 110);
            this.countryChart.Name = "countryChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "City";
            this.countryChart.Series.Add(series2);
            this.countryChart.Size = new System.Drawing.Size(1097, 631);
            this.countryChart.TabIndex = 9;
            // 
            // resButton
            // 
            this.resButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.resButton.Location = new System.Drawing.Point(12, 54);
            this.resButton.Name = "resButton";
            this.resButton.Size = new System.Drawing.Size(93, 52);
            this.resButton.TabIndex = 10;
            this.resButton.Text = "Reset";
            this.resButton.UseVisualStyleBackColor = false;
            this.resButton.Click += new System.EventHandler(this.resButton_Click);
            // 
            // Form_worldCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 753);
            this.Controls.Add(this.resButton);
            this.Controls.Add(this.countryChart);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.label_Population);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.label_PopulationText);
            this.Controls.Add(this.label_CountryText);
            this.Controls.Add(this.label_City);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_worldCities";
            this.Text = "Cities of the World";
            ((System.ComponentModel.ISupportInitialize)(this.countryChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_City;
		private System.Windows.Forms.Label label_CountryText;
		private System.Windows.Forms.Label label_PopulationText;
		private System.Windows.Forms.ComboBox comboBox_City;
		private System.Windows.Forms.Label label_Population;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.DataVisualization.Charting.Chart countryChart;
        private System.Windows.Forms.Button resButton;
    }
}

