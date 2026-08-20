using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockMarketSimGame
{
    public class Stock
    {
        public string stockName = "DefaultStockName";
        private double stockValue;
        public double StockValue
        {
            get { return stockValue; }
            set
            {
                stockValue = Math.Max(stockValue, 0);
            }
        }
        public double stockTrend { get; set; }

        public Stock(string name, double initialStockValue)
        {
            stockName = name;
            StockValue = initialStockValue;
        }
    }
}
