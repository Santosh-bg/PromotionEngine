using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Entities;

namespace PromotionEngine.PromotionRules
{
    class SkuACountRule : ISkuACountRule
    {
        public int GetPromotionAppliedAmountForSkuA(Cartitem cartitem)
        {
            int amount = 0;
            return amount;
        }
    }
}
