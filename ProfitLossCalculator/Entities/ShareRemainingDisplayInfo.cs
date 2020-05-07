using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitLossCalculator.Entity
{
    public class ShareRemainingDisplayInfo
    {
        public decimal CostPriceSoldShares { get; set; }
        public decimal ProfitLoss { get; set; }
        public int RemainingShares { get; set; }
        public decimal CostPriceRemainingSharesPerQuantity { get; set; }
    }
}
