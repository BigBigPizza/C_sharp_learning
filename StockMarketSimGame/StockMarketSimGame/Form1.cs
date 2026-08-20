using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarketSimGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Stocks
            Stock spaceStock = new Stock("Space CO", 200);
            Stock farmStock = new Stock("Dirt CO", 10);
            Stock steelStock = new Stock("Irn CO", 50);

            List<Stock> stockList = new List<Stock> { spaceStock, farmStock, steelStock };

            //Initial Value
            double playerStartMoney = 10000;


    }

        private void BuyButton_Click(object sender, EventArgs e)
        {

        }

        private void SellButton_Click(object sender, EventArgs e)
        {

        }
    }
}
