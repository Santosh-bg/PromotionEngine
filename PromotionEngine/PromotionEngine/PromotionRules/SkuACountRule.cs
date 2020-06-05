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
            int remainigQuantity;
            int promotionQuantity = Math.DivRem(cartitem.Quantity, 3, out remainigQuantity);
            amount = (promotionQuantity * 130) + (remainigQuantity * 50);
            return amount;
        }
    }
}
