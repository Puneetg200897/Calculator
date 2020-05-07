using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitLossCalculator.BusinessLogic;
using ProfitLossCalculator.Entity;
using ProfitLossCalculator.Helper;
namespace ProfitLossCalculator
{
    public partial class Form1 : Form
    {
        Calulator Calc;
        ShareSellInfo ShareSellInfo;

        public Form1()
        {
            InitializeComponent();
            Calc = new Calulator();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ShareSellInfo = new ShareSellInfo();
            try
            {

                if (!Helper.Helper.Required(txtSharesSold) || !Helper.Helper.Required(txtPricePerShare) || !Helper.Helper.Required(txtSellDate))
                {
                    return;
                }

                if (!Helper.Helper.NonNegativeInteger(txtSharesSold) || !Helper.Helper.NonNegativeDecimal(txtPricePerShare) || !Helper.Helper.ValidDate(txtSellDate))
                {
                    return;
                }

                int soldShares = int.Parse(txtSharesSold.Text);              

                int remainingShares = lblRemainingShares.Text == String.Empty ? Calc.GetTotalShares() : int.Parse(lblRemainingShares.Text);

                if (soldShares > remainingShares)
                {
                    MessageBox.Show("Available shares: " + remainingShares.ToString()+".");
                    return;
                }

                DateTime lastSharePurcahaseDate = Calc.GetLastSharePurchaseDate();
                if (DateTime.Parse(txtSellDate.Text) < lastSharePurcahaseDate)
                {
                    MessageBox.Show("Sell Date can not be less than " + lastSharePurcahaseDate.ToString("dd/MM/yyyy") + ".");
                    return;
                }

                ShareSellInfo.Quantity = soldShares;
                ShareSellInfo.Price = decimal.Parse(txtPricePerShare.Text);
                ShareSellInfo.SellingDate = DateTime.Parse(txtSellDate.Text);

                ShareRemainingDisplayInfo shareRemainingDisplayInfo = Calc.Calculate(ShareSellInfo);

                lblRemainingShares.Text = shareRemainingDisplayInfo.RemainingShares.ToString();
                lblCostPriceSoldShares.Text = shareRemainingDisplayInfo.CostPriceSoldShares.ToString();
                lblCostPriceRemainingShares.Text = shareRemainingDisplayInfo.CostPriceRemainingSharesPerQuantity.ToString();
                lblGainLoss.Text = shareRemainingDisplayInfo.ProfitLoss.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please restart your application.");
            }
        }


    }
}
