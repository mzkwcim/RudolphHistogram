using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Rudolph_Points = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Rudolph_Points2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Rudolph_Points3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Rudolph_Points4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Rudolph_Points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rudolph_Points2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rudolph_Points3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rudolph_Points4)).BeginInit();
            this.SuspendLayout();
            // 
            // Rudolph_Points
            // 
            chartArea1.Name = "ChartArea1";
            this.Rudolph_Points.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Rudolph_Points.Legends.Add(legend1);
            this.Rudolph_Points.Location = new System.Drawing.Point(69, 88);
            this.Rudolph_Points.Name = "Rudolph_Points";
            this.Rudolph_Points.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Rudolph_Points";
            this.Rudolph_Points.Series.Add(series1);
            this.Rudolph_Points.Size = new System.Drawing.Size(323, 326);
            this.Rudolph_Points.TabIndex = 0;
            this.Rudolph_Points.Text = "Rudolph_Points";
            title1.Name = "Rudolph Points";
            title1.Text = "50m kraulem 14 lat mężczyzn";
            this.Rudolph_Points.Titles.Add(title1);
            this.Rudolph_Points.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Rudolph_Points2
            // 
            chartArea2.Name = "ChartArea1";
            this.Rudolph_Points2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Rudolph_Points2.Legends.Add(legend2);
            this.Rudolph_Points2.Location = new System.Drawing.Point(407, 88);
            this.Rudolph_Points2.Name = "Rudolph_Points2";
            this.Rudolph_Points2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Rudolph_Points2";
            this.Rudolph_Points2.Series.Add(series2);
            this.Rudolph_Points2.Size = new System.Drawing.Size(323, 326);
            this.Rudolph_Points2.TabIndex = 1;
            this.Rudolph_Points2.Text = "Rudolph_Points2";
            title2.Name = "Rudolph_Points2";
            title2.Text = "100m kraulem 14 lat mężczyzn";
            this.Rudolph_Points2.Titles.Add(title2);
            // 
            // Rudolph_Points3
            // 
            chartArea3.Name = "ChartArea1";
            this.Rudolph_Points3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Rudolph_Points3.Legends.Add(legend3);
            this.Rudolph_Points3.Location = new System.Drawing.Point(758, 88);
            this.Rudolph_Points3.Name = "Rudolph_Points3";
            this.Rudolph_Points3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Rudolph_Points3";
            this.Rudolph_Points3.Series.Add(series3);
            this.Rudolph_Points3.Size = new System.Drawing.Size(323, 326);
            this.Rudolph_Points3.TabIndex = 2;
            this.Rudolph_Points3.Text = "Rudolph_Points3";
            title3.Name = "Rudolph_Points3";
            title3.Text = "200m kraulem 14 lat mężczyzn";
            this.Rudolph_Points3.Titles.Add(title3);
            // 
            // Rudolph_Points4
            // 
            chartArea4.Name = "ChartArea1";
            this.Rudolph_Points4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Rudolph_Points4.Legends.Add(legend4);
            this.Rudolph_Points4.Location = new System.Drawing.Point(1099, 88);
            this.Rudolph_Points4.Name = "Rudolph_Points4";
            this.Rudolph_Points4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Rudolph_Points4";
            this.Rudolph_Points4.Series.Add(series4);
            this.Rudolph_Points4.Size = new System.Drawing.Size(323, 326);
            this.Rudolph_Points4.TabIndex = 3;
            this.Rudolph_Points4.Text = "Rudolph_Points4";
            title4.Name = "Rudolph_Points4";
            title4.Text = "400m kraulem 14 lat mężczyzn";
            this.Rudolph_Points4.Titles.Add(title4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 648);
            this.Controls.Add(this.Rudolph_Points4);
            this.Controls.Add(this.Rudolph_Points3);
            this.Controls.Add(this.Rudolph_Points2);
            this.Controls.Add(this.Rudolph_Points);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rudolph_Points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rudolph_Points2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rudolph_Points3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rudolph_Points4)).EndInit();
            this.ResumeLayout(false);

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Rudolph_Points;
        private System.Windows.Forms.DataVisualization.Charting.Chart Rudolph_Points2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Rudolph_Points3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Rudolph_Points4;
    }
}

