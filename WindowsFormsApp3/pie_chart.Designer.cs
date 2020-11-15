namespace WindowsFormsApp3
{
    partial class pie_chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ct2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.ct1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.ct3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.ct4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct4)).BeginInit();
            this.SuspendLayout();
            // 
            // ct2
            // 
            chartArea13.Name = "ChartArea1";
            this.ct2.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.ct2.Legends.Add(legend13);
            this.ct2.Location = new System.Drawing.Point(382, 24);
            this.ct2.Name = "ct2";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series13.Legend = "Legend1";
            series13.Name = "OneWeek";
            this.ct2.Series.Add(series13);
            this.ct2.Size = new System.Drawing.Size(367, 205);
            this.ct2.TabIndex = 0;
            this.ct2.Text = "chart1";
            this.ct2.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(246, 149);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "label1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(246, 179);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "label2";
            // 
            // ct1
            // 
            chartArea14.Name = "ChartArea1";
            this.ct1.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.ct1.Legends.Add(legend14);
            this.ct1.Location = new System.Drawing.Point(0, 24);
            this.ct1.Name = "ct1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series14.Legend = "Legend1";
            series14.Name = "CurrentDate";
            this.ct1.Series.Add(series14);
            this.ct1.Size = new System.Drawing.Size(367, 205);
            this.ct1.TabIndex = 0;
            this.ct1.Text = "chart1";
            this.ct1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(631, 149);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(35, 13);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "label1";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(631, 179);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(35, 13);
            this.lbl4.TabIndex = 2;
            this.lbl4.Text = "label2";
            // 
            // ct3
            // 
            chartArea15.Name = "ChartArea1";
            this.ct3.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.ct3.Legends.Add(legend15);
            this.ct3.Location = new System.Drawing.Point(0, 244);
            this.ct3.Name = "ct3";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series15.Legend = "Legend1";
            series15.Name = "OneMonth";
            this.ct3.Series.Add(series15);
            this.ct3.Size = new System.Drawing.Size(367, 205);
            this.ct3.TabIndex = 0;
            this.ct3.Text = "chart1";
            this.ct3.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(246, 388);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(35, 13);
            this.lbl5.TabIndex = 1;
            this.lbl5.Text = "label1";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(246, 414);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(35, 13);
            this.lbl6.TabIndex = 2;
            this.lbl6.Text = "label2";
            // 
            // ct4
            // 
            chartArea16.Name = "ChartArea1";
            this.ct4.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.ct4.Legends.Add(legend16);
            this.ct4.Location = new System.Drawing.Point(382, 244);
            this.ct4.Name = "ct4";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series16.Legend = "Legend1";
            series16.Name = "Oneyear";
            this.ct4.Series.Add(series16);
            this.ct4.Size = new System.Drawing.Size(367, 205);
            this.ct4.TabIndex = 0;
            this.ct4.Text = "chart1";
            this.ct4.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(631, 388);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(35, 13);
            this.lbl7.TabIndex = 1;
            this.lbl7.Text = "label1";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(631, 414);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(35, 13);
            this.lbl8.TabIndex = 2;
            this.lbl8.Text = "label2";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(354, 2);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(43, 20);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "NULL";
            // 
            // pie_chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 451);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.ct4);
            this.Controls.Add(this.ct3);
            this.Controls.Add(this.ct1);
            this.Controls.Add(this.ct2);
            this.Name = "pie_chart";
            this.Text = "Piechart";
            this.Load += new System.EventHandler(this.Piechart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ct2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct4;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblusername;
    }
}