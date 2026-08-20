namespace StockMarketSimGame
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.stockChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StockListView = new System.Windows.Forms.ListView();
            this.stockListHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockListHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BuyButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.PlayerBalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockChart)).BeginInit();
            this.SuspendLayout();
            // 
            // stockChart
            // 
            chartArea4.Name = "ChartArea1";
            this.stockChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.stockChart.Legends.Add(legend4);
            this.stockChart.Location = new System.Drawing.Point(28, 44);
            this.stockChart.Name = "stockChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.CustomProperties = "EmptyPointValue=Zero";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.stockChart.Series.Add(series7);
            this.stockChart.Series.Add(series8);
            this.stockChart.Size = new System.Drawing.Size(459, 300);
            this.stockChart.TabIndex = 0;
            this.stockChart.Text = "Stock Chart";
            title7.Name = "stockChartTitle";
            title7.Text = "Value";
            title8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title8.Name = "stockChartYAxisTitle";
            title8.Text = "Stock Value (£)";
            this.stockChart.Titles.Add(title7);
            this.stockChart.Titles.Add(title8);
            // 
            // StockListView
            // 
            this.StockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stockListHeader1,
            this.stockListHeader2});
            this.StockListView.FullRowSelect = true;
            this.StockListView.GridLines = true;
            this.StockListView.HideSelection = false;
            this.StockListView.Location = new System.Drawing.Point(537, 44);
            this.StockListView.MultiSelect = false;
            this.StockListView.Name = "StockListView";
            this.StockListView.Size = new System.Drawing.Size(218, 257);
            this.StockListView.TabIndex = 1;
            this.StockListView.UseCompatibleStateImageBehavior = false;
            this.StockListView.View = System.Windows.Forms.View.Details;
            // 
            // stockListHeader1
            // 
            this.stockListHeader1.Text = "Stock Name";
            this.stockListHeader1.Width = 126;
            // 
            // stockListHeader2
            // 
            this.stockListHeader2.Text = "Stock Value (£)";
            this.stockListHeader2.Width = 88;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(537, 320);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 2;
            this.BuyButton.Text = "BUY";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(680, 320);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(75, 23);
            this.SellButton.TabIndex = 3;
            this.SellButton.Text = "SELL";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // PlayerBalanceLabel
            // 
            this.PlayerBalanceLabel.AutoSize = true;
            this.PlayerBalanceLabel.Location = new System.Drawing.Point(624, 359);
            this.PlayerBalanceLabel.Name = "PlayerBalanceLabel";
            this.PlayerBalanceLabel.Size = new System.Drawing.Size(43, 13);
            this.PlayerBalanceLabel.TabIndex = 4;
            this.PlayerBalanceLabel.Text = "£10000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerBalanceLabel);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.StockListView);
            this.Controls.Add(this.stockChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stockChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart stockChart;
        private System.Windows.Forms.ListView StockListView;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Label PlayerBalanceLabel;
        public System.Windows.Forms.ColumnHeader stockListHeader1;
        public System.Windows.Forms.ColumnHeader stockListHeader2;
    }
}

