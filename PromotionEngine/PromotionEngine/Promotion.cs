using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Entities;
using PromotionEngine.PromotionRules;

namespace PromotionEngine
{
    public class Promotion : IPromotion
    {
        public int Process(Cart cart)
        {
            int TotalAmountAfterPromotionApplied = 0;
            SkuACountRule skuAcountRule = new SkuACountRule();
            var skuACartItems = cart.Cartitems.FindAll(x => x.Skuname.Equals("A"));
            var amountForA = skuAcountRule.GetPromotionAppliedAmountForSkuA(skuACartItems[0]);

            SkuBCountRule skuBcountRule = new SkuBCountRule();
            var skuBCartItems = cart.Cartitems.FindAll(x => x.Skuname.Equals("B"));
            var amountForB = skuBcountRule.GetPromotionAppliedAmountForSkuB(skuACartItems[0]);

            SkuCandDCountRule skuCandDcountRule = new SkuCandDCountRule();
            var skuCandDCartItems = cart.Cartitems.FindAll(x => x.Skuname.Equals("C") || x.Equals("D"));
            var amountForCandD = skuCandDcountRule.GetPromotionAppliedAmountForSkuCandD(skuCandDCartItems);

            return TotalAmountAfterPromotionApplied = amountForA + amountForB + amountForCandD;
        }
    }
}
