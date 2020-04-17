namespace CRM_Project.Src.Controls
{
    partial class UcHome
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblTxtTodatyDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumberClients = new System.Windows.Forms.Label();
            this.lblTxtNumberClients = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblActiveEvents = new System.Windows.Forms.Label();
            this.lblTxtActiveEvents = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEventChart = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lblTodayDate);
            this.panel1.Controls.Add(this.lblTxtTodatyDate);
            this.panel1.Location = new System.Drawing.Point(20, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 120);
            this.panel1.TabIndex = 0;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTodayDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblTodayDate.Location = new System.Drawing.Point(0, 65);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(268, 39);
            this.lblTodayDate.TabIndex = 8;
            this.lblTodayDate.Text = "0";
            this.lblTodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTxtTodatyDate
            // 
            this.lblTxtTodatyDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblTxtTodatyDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblTxtTodatyDate.Location = new System.Drawing.Point(0, 25);
            this.lblTxtTodatyDate.Name = "lblTxtTodatyDate";
            this.lblTxtTodatyDate.Size = new System.Drawing.Size(268, 19);
            this.lblTxtTodatyDate.TabIndex = 4;
            this.lblTxtTodatyDate.Text = "Dzisiejsza Data";
            this.lblTxtTodatyDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lblNumberClients);
            this.panel2.Controls.Add(this.lblTxtNumberClients);
            this.panel2.Location = new System.Drawing.Point(308, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 120);
            this.panel2.TabIndex = 1;
            // 
            // lblNumberClients
            // 
            this.lblNumberClients.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumberClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblNumberClients.Location = new System.Drawing.Point(0, 65);
            this.lblNumberClients.Name = "lblNumberClients";
            this.lblNumberClients.Size = new System.Drawing.Size(268, 39);
            this.lblNumberClients.TabIndex = 7;
            this.lblNumberClients.Text = "0";
            this.lblNumberClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTxtNumberClients
            // 
            this.lblTxtNumberClients.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblTxtNumberClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblTxtNumberClients.Location = new System.Drawing.Point(0, 25);
            this.lblTxtNumberClients.Name = "lblTxtNumberClients";
            this.lblTxtNumberClients.Size = new System.Drawing.Size(268, 19);
            this.lblTxtNumberClients.TabIndex = 6;
            this.lblTxtNumberClients.Text = "Liczba Klientów w Bazie Danych";
            this.lblTxtNumberClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.lblActiveEvents);
            this.panel3.Controls.Add(this.lblTxtActiveEvents);
            this.panel3.Location = new System.Drawing.Point(596, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 120);
            this.panel3.TabIndex = 1;
            // 
            // lblActiveEvents
            // 
            this.lblActiveEvents.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActiveEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblActiveEvents.Location = new System.Drawing.Point(0, 65);
            this.lblActiveEvents.Name = "lblActiveEvents";
            this.lblActiveEvents.Size = new System.Drawing.Size(268, 39);
            this.lblActiveEvents.TabIndex = 8;
            this.lblActiveEvents.Text = "0";
            this.lblActiveEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTxtActiveEvents
            // 
            this.lblTxtActiveEvents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblTxtActiveEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblTxtActiveEvents.Location = new System.Drawing.Point(0, 25);
            this.lblTxtActiveEvents.Name = "lblTxtActiveEvents";
            this.lblTxtActiveEvents.Size = new System.Drawing.Size(268, 19);
            this.lblTxtActiveEvents.TabIndex = 7;
            this.lblTxtActiveEvents.Text = "Liczba Aktywnych Wydarzeń";
            this.lblTxtActiveEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Bisque;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Maroon;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 160);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Events";
            series1.YValuesPerPoint = 4;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(884, 341);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // lblEventChart
            // 
            this.lblEventChart.AutoSize = true;
            this.lblEventChart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblEventChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.lblEventChart.Location = new System.Drawing.Point(20, 140);
            this.lblEventChart.Name = "lblEventChart";
            this.lblEventChart.Size = new System.Drawing.Size(213, 19);
            this.lblEventChart.TabIndex = 3;
            this.lblEventChart.Text = "Wykres Wydarzeń w Miesiącu";
            // 
            // UcHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblEventChart);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcHome";
            this.Size = new System.Drawing.Size(884, 501);
            this.Load += new System.EventHandler(this.UcHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label lblEventChart;
        private System.Windows.Forms.Label lblTxtTodatyDate;
        private System.Windows.Forms.Label lblTxtNumberClients;
        private System.Windows.Forms.Label lblTxtActiveEvents;
        private System.Windows.Forms.Label lblNumberClients;
        private System.Windows.Forms.Label lblActiveEvents;
        private System.Windows.Forms.Label lblTodayDate;
    }
}
