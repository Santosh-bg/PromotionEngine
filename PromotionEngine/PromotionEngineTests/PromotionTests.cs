using PromotionEngine;
using PromotionEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PromotionEngineTests
{
    public class PromotionTests
    {
        [Fact]
        public void ScenarioA()
        {
            var carts = new Cart
            {
                Cartitems = new List<Cartitem> {new Cartitem{Skuname = "A",Quantity=5 },
                    new Cartitem{Skuname = "A",Quantity=1 ,Price=50},
                    new Cartitem{Skuname = "B",Quantity=1,Price=30 },
                    new Cartitem{Skuname = "C",Quantity=5,Price=20 } }
            };
            Promotion promotion = new Promotion();
            var value = promotion.Process(carts);
            Assert.Equal(100, value);
        }

        [Fact]
        public void ScenarioB()
        {
            var carts = new Cart
            {
                Cartitems = new List<Cartitem> {new Cartitem{Skuname = "A",Quantity=5 },
                    new Cartitem{Skuname = "A",Quantity=5 ,Price=250},
                    new Cartitem{Skuname = "B",Quantity=1,Price=150 },
                    new Cartitem{Skuname = "C",Quantity=5,Price=20 } }
            };
            Promotion promotion = new Promotion();
            var value = promotion.Process(carts);
            Assert.Equal(370, value);
        }

        [Fact]
        public void ScenarioC()
        {
            var carts = new Cart
            {
                Cartitems = new List<Cartitem> {new Cartitem{Skuname = "A",Quantity=5 },
                    new Cartitem{Skuname = "A",Quantity=3 ,Price=150},
                    new Cartitem{Skuname = "B",Quantity=5,Price=150},
                    new Cartitem{Skuname = "C",Quantity=1,Price=20 },
                    new Cartitem{Skuname = "D",Quantity=1,Price=20 } }
            };
            Promotion promotion = new Promotion();
            var value = promotion.Process(carts);
            Assert.Equal(280, value);
        }

        //public void ScenarioD()
        //{
        //    var carts = new Cart
        //    {
        //        Cartitems = new List<Cartitem> {new Cartitem{Skuname = "A",Quantity=5 },
        //            new Cartitem{Skuname = "A",Quantity=1 ,Price=50},
        //            new Cartitem{Skuname = "B",Quantity=1,Price=30 },
        //            new Cartitem{Skuname = "C",Quantity=5,Price=20 } }
        //    };
        //    Promotion promotion = new Promotion();
        //    var value = promotion.Process(carts);
        //    Assert.Equal(100, value);
        //}
    }
}
