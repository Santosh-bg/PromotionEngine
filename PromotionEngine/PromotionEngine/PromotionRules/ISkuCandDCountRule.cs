using PromotionEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionRules
{
    interface ISkuCandDCountRule
    {
        int GetPromotionAppliedAmountForSkuCandD(List<Cartitem> cartitem);
    }
}
