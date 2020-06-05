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
            int amountForA = 0;
            int amountForB = 0;
            int amountForCandD = 0;
            PromotionRuleFactory promotionRuleFactory = new PromotionRuleFactory();
           
            var skuACartItems = cart.Cartitems.FindAll(x => x.Skuname.Equals("A"));
            if (skuACartItems != null && skuACartItems.Count > 0)
            {
                var skuAcountRule = promotionRuleFactory.GetPromotionRule(skuACartItems[0].Skuname);
                var obj= skuAcountRule as SkuACountRule;   
                amountForA = obj.GetPromotionAppliedAmountForSkuA(skuACartItems[0]);
            }
         //   SkuBCountRule skuBcountRule = new SkuBCountRule();
            var skuBCartItems = cart.Cartitems.FindAll(x => x.Skuname.Equals("B"));
            if (skuBCartItems != null && skuBCartItems.Count > 0)
            {
                var skuAcountRule = promotionRuleFactory.GetPromotionRule(skuBCartItems[0].Skuname);
                var obj = skuAcountRule as SkuBCountRule;

                amountForB = obj.GetPromotionAppliedAmountForSkuB(skuBCartItems[0]);
            }
            SkuCandDCountRule skuCandDcountRule = new SkuCandDCountRule();
            var skuCandDCartItems = cart.Cartitems.FindAll(x => x.Skuname.Equals("C") || x.Skuname.Equals("D"));
            if(skuCandDCartItems != null && skuCandDCartItems.Count>0)
            {
                var skuAcountRule = promotionRuleFactory.GetPromotionRule(skuCandDCartItems[0].Skuname);
                var obj = skuAcountRule as SkuCandDCountRule;
                amountForCandD = skuCandDcountRule.GetPromotionAppliedAmountForSkuCandD(skuCandDCartItems);
            }
                

            return TotalAmountAfterPromotionApplied = amountForA + amountForB + amountForCandD;
        }
    }
}
