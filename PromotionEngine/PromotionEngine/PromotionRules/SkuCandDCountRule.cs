using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Entities;

namespace PromotionEngine.PromotionRules
{
    class SkuCandDCountRule : ISkuCandDCountRule
    {
        public int GetPromotionAppliedAmountForSkuB(Cartitem cartitem)
        {
            int amount = 0;
            return amount;
        }
    }
}
