using PromotionEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionRules
{
    class SkuBCountRule : ISkuBCountRule
    {
        public int GetPromotionAppliedAmountForSkuB(Cartitem cartitem)
        {
            int amount = 0;
            return amount;
        }
    }
}
