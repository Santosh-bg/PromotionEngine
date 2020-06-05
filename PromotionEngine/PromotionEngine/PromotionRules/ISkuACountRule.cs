using PromotionEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionRules
{
    interface ISkuACountRule
    {
        int GetPromotionAppliedAmountForSkuA(Cartitem cartitem);
    }
}
