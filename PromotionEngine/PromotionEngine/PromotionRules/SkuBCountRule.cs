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
            int remainigQuantity;
            int promotionQuantity = Math.DivRem(cartitem.Quantity, 2, out remainigQuantity);
            amount = (promotionQuantity * 45) + (remainigQuantity * 30);
            return amount;
        }
    }
}
