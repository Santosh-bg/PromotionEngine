using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Constants;
using PromotionEngine.Entities;

namespace PromotionEngine.PromotionRules
{
    class SkuACountRule : KsuCountRuleBase, ISkuACountRule
    {
        public int GetPromotionAppliedAmountForSkuA(Cartitem cartitem)
        {
            int amount = 0;
            int remainigQuantity;
            int promotionQuantity = Math.DivRem(cartitem.Quantity, PromotionQuantity.KsuAPromotionQuantity, out remainigQuantity);
            amount = (promotionQuantity * 130) + (remainigQuantity * 50);
            return amount;
        }
    }
}
