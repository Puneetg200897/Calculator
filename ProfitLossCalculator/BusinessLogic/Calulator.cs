using ProfitLossCalculator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitLossCalculator.BusinessLogic
{
    public class Calulator
    {
        public List<ShareCostInfo> ShareCostInfomation;
        public List<ShareSellInfo> ShareSellInfomation;

        public Calulator()
        {
            ShareCostInfomation = GetShareCostInfo().OrderBy(x => x.PurchaseDate).ToList();
            ShareSellInfomation = new List<ShareSellInfo>();
        }

        // Mock input data for costing of share.
        private List<ShareCostInfo> GetShareCostInfo()
        {
            List<ShareCostInfo> shareCostInfomation = new List<ShareCostInfo>();
            shareCostInfomation.Add(new ShareCostInfo() { PricePerQuantity = 10, Quantity = 100, PurchaseDate = DateTime.Parse("1/1/2005") });
            shareCostInfomation.Add(new ShareCostInfo() { PricePerQuantity = 12, Quantity = 40, PurchaseDate = DateTime.Parse("2/2/2005") });
            shareCostInfomation.Add(new ShareCostInfo() { PricePerQuantity = 11, Quantity = 50, PurchaseDate = DateTime.Parse("3/3/2005") });

            return shareCostInfomation;
        }
        
        // Getting total cost price of share sold.
        private decimal GetCostPriceSoldShares(List<ShareCostInfo> shareCostInfomation, int totalSharesSoldQty)
        {
            int remainingQty = totalSharesSoldQty;
            decimal totalShareCostPrice = 0;
            foreach (var scInfo in shareCostInfomation)
            {
                if (remainingQty > scInfo.Quantity)
                {
                    totalShareCostPrice += scInfo.Quantity * scInfo.PricePerQuantity;
                    remainingQty = remainingQty - scInfo.Quantity;
                }
                else
                {
                    totalShareCostPrice += remainingQty * scInfo.PricePerQuantity;
                    break;
                }
            }
            return totalShareCostPrice;
        }

        // Getting total selling price of share sold.
        private decimal GetSellPriceSoldShares(List<ShareSellInfo> shareSellInfomation)
        {
            return shareSellInfomation.Sum(x => (x.Quantity * x.Price));
        }

        // Getting cost price of share remaining.
        private decimal GetCostPriceRemainingShares(List<ShareCostInfo> shareCostInfomation, decimal totalCostPriceSoldShare)
        {
            Decimal totalSharesPrice = shareCostInfomation.Sum(x => (x.Quantity * x.PricePerQuantity));
            return totalSharesPrice - totalCostPriceSoldShare;
        }

        // Getting total share quantity.
        public int GetTotalShares() {
            return ShareCostInfomation.Sum(x => x.Quantity);
        }

        // Getting last purchase date of shares.
        public DateTime GetLastSharePurchaseDate()
        {
            return ShareCostInfomation.Max(x => x.PurchaseDate);
        }

        // Calculate data of remaining share, cost price of sold share, cost price of remaining share per quantity and actual Profit or loss.
        public ShareRemainingDisplayInfo Calculate(ShareSellInfo shareSellInfo)
        {
            ShareSellInfomation.Add(shareSellInfo);

            int totalSharesPurchase = ShareCostInfomation.Sum(x => x.Quantity);
            int totalSharesSold = ShareSellInfomation.Sum(y => y.Quantity);
            int remainingShares = totalSharesPurchase - totalSharesSold;

            decimal costPriceSoldShares = GetCostPriceSoldShares(ShareCostInfomation, totalSharesSold);
            decimal sellPriceSoldShares = GetSellPriceSoldShares(ShareSellInfomation);
            decimal CostPriceRemainingShares = GetCostPriceRemainingShares(ShareCostInfomation, costPriceSoldShares);


            ShareRemainingDisplayInfo shareRemainingDisplayInfo = new ShareRemainingDisplayInfo();

            shareRemainingDisplayInfo.RemainingShares = remainingShares;
            shareRemainingDisplayInfo.CostPriceSoldShares = Math.Round(costPriceSoldShares / totalSharesSold, 3);
            shareRemainingDisplayInfo.CostPriceRemainingSharesPerQuantity = remainingShares!=0? Math.Round(CostPriceRemainingShares / remainingShares, 8):0;
            shareRemainingDisplayInfo.ProfitLoss = Math.Round(sellPriceSoldShares - costPriceSoldShares, 0);

            return shareRemainingDisplayInfo;
        }
    }
}
