using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionRules
{
    class PromotionRuleFactory : IpromotionRuleFactory
    {
        public KsuCountRuleBase GetPromotionRule(string skuname)
        {
            switch(skuname)
            {
                case "A":
                    return new SkuACountRule();
                case "B":
                    return new SkuBCountRule();
                case "C":
                case "D":
                    return new SkuCandDCountRule();
                default:
                    throw new Exception();
            }
        }
    }
}
