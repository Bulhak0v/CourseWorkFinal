namespace CourseWork.Forms
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            GenresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            StudiosChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ArtistsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DirectorsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)GenresChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudiosChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ArtistsChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DirectorsChart).BeginInit();
            SuspendLayout();
            // 
            // GenresChart
            // 
            chartArea1.Name = "ChartArea1";
            GenresChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Genres";
            GenresChart.Legends.Add(legend1);
            GenresChart.Location = new Point(12, 12);
            GenresChart.Name = "GenresChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Genres";
            GenresChart.Series.Add(series1);
            GenresChart.Size = new Size(790, 442);
            GenresChart.TabIndex = 0;
            GenresChart.Text = "chart1";
            // 
            // StudiosChart
            // 
            StudiosChart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            StudiosChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Studios";
            legend2.Title = "Studios";
            StudiosChart.Legends.Add(legend2);
            StudiosChart.Location = new Point(808, 0);
            StudiosChart.Name = "StudiosChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Studios";
            series2.Name = "Series1";
            StudiosChart.Series.Add(series2);
            StudiosChart.Size = new Size(1082, 454);
            StudiosChart.TabIndex = 1;
            StudiosChart.Text = "chart2";
            // 
            // ArtistsChart
            // 
            ArtistsChart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea3.Name = "ChartArea1";
            ArtistsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Studios";
            legend3.Title = "Artists";
            ArtistsChart.Legends.Add(legend3);
            ArtistsChart.Location = new Point(808, 460);
            ArtistsChart.Name = "ArtistsChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Studios";
            series3.Name = "Series1";
            ArtistsChart.Series.Add(series3);
            ArtistsChart.Size = new Size(1082, 561);
            ArtistsChart.TabIndex = 2;
            ArtistsChart.Text = "chart2";
            // 
            // DirectorsChart
            // 
            DirectorsChart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chartArea4.Name = "ChartArea1";
            DirectorsChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Studios";
            legend4.Title = "Directors";
            DirectorsChart.Legends.Add(legend4);
            DirectorsChart.Location = new Point(12, 460);
            DirectorsChart.Name = "DirectorsChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Studios";
            series4.Name = "Series1";
            DirectorsChart.Series.Add(series4);
            DirectorsChart.Size = new Size(790, 561);
            DirectorsChart.TabIndex = 3;
            DirectorsChart.Text = "chart2";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(DirectorsChart);
            Controls.Add(ArtistsChart);
            Controls.Add(StudiosChart);
            Controls.Add(GenresChart);
            MinimumSize = new Size(1820, 1078);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)GenresChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudiosChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)ArtistsChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)DirectorsChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GenresChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart StudiosChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ArtistsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DirectorsChart;
    }
}