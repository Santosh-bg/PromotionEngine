using PromotionEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    interface IPromotion
    {
        decimal Process(Cart cart);
    }
}
