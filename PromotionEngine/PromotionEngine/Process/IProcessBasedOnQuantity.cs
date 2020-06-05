using PromotionEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Process
{
    interface IProcessBasedOnQuantity
    {
        int ProcessAmoutBasedOnCountPromotion(Cart cart);
    }
}
