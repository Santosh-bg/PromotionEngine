using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Entities;
using PromotionEngine.Process;
using PromotionEngine.PromotionRules;

namespace PromotionEngine
{
    public class Promotion : IPromotion
    {        
        public int Process(Cart cart)
        {
            ProcessBasedOnQuantity processBasedOnQuantity = new ProcessBasedOnQuantity();
            return processBasedOnQuantity.ProcessAmoutBasedOnCountPromotion(cart);
        }
    }
}
