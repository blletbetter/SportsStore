using System;
using SportsStore.Models;
using System.Collections.Generic;
using Xunit;

namespace SportsStoreUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void BasketCountTotalTest()
        {
            var basket = new Basket();
            var p1 = new Stick("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "good", "wood", Player.FieldPlayer, Grip.Left, 0.8);
            var p2 = new Skates("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "sss", "wood");
            var p3 = new Helmet("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "sss", true, Player.FieldPlayer);
            basket.AddItem(p1, 2);
            basket.AddItem(p2);
            basket.AddItem(p3, 4);
            Assert.Equal("1400", basket.CountTotal().ToString());
        }

        [Fact]
        public void DescriptionTest()
        {
            var basket = new Basket();
            var p1 = new Stick("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "good", "wood", Player.FieldPlayer, Grip.Left, 0.8);
            var p2 = new Skates("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "sss", "wood");
            var p3 = new Helmet("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "sss", true, Player.FieldPlayer);
            basket.AddItem(p1, 2);
            basket.AddItem(p2);
            basket.AddItem(p3, 4);
            List<HockeyProduct> result = basket.DescriptionSearch("sss");
            List<HockeyProduct> fact = new List<HockeyProduct>();
            fact.Add(p2);
            fact.Add(p3);
            bool a = true;
            for (int i = 0; i < fact.Count; i++)
            {
                if (fact[i] != result[i])
                {
                    a = false;
                    break;
                }
            }
            Assert.True(a);
        }

        [Fact]
        public void LogInTest()
        {
            string un = "user";
            string pw = "1234";
            var client = new Client("user", 18, "1234", "1234", "asdasd");
            Assert.True(client.LogIn(un, pw));
        }

        [Fact]
        public void ChangePasswordTest()
        {
            var client = new Client("user", 18, "1234", "1234", "asdasd");
            Assert.False(client.ChangePassword("124", "123", "122"));
        }

        [Fact]
        public void CreditCardPayCorrectTest()
        {
            var card = new CreditCard(DateTime.Now.AddYears(3), "Igor", "1321", 132);
            card.AddMoney(500);
            Assert.True(card.Pay(100, "1321"));
        }

        [Fact]
        public void CreditCardPayIncorrectTest()
        {
            var card = new CreditCard(DateTime.Now.AddYears(3), "Igor", "1321", 132);
            card.AddMoney(500);
            Assert.False(card.Pay(1000, "1321"));
        }

        [Fact]
        public void CountDiscountTest()
        {
            var card = new DiscountCard(DateTime.Now.AddYears(11), new Client("user", 18, "1234", "1234", "asdasd"));
            Assert.True(95.0m == card.CountSumWithDiscount(100));
        }

        [Fact]
        public void AddItemCorrectPasswordTest()
        {
            var store = new Store("1234");
            var admin = new Admin("das", 18, "12", "12", DateTime.Now, 0);
            var product = new Stick("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "good", "wood", Player.FieldPlayer, Grip.Left, 0.8);
            admin.AddProductToStore(store, product, "1234", 5);
            Assert.True(1000m == store.FullStoreProductsCost());
        }

        [Fact]
        public void AddIteIncorrectPasswordTest()
        {
            var store = new Store("1234");
            var admin = new Admin("das", 18, "12", "12", DateTime.Now, 0);
            var product = new Stick("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "good", "wood", Player.FieldPlayer, Grip.Left, 0.8);
            admin.AddProductToStore(store, product, "134", 5);
            Assert.True(0m == store.FullStoreProductsCost());
        }

        [Fact]
        public void CreateDiscountCardTest()
        {
            var creditCard = new CreditCard(DateTime.Now.AddDays(5), "Igor", "123", 222);
            var client = new Client("user", 18, "1234", "1234", "asdasd");
            var store = new Store("1234");
            creditCard.AddMoney(500);
            client.AddCreditCard(creditCard);
            store.RegisterDiscountCard(client, "123");
            Assert.True(client.DiscountCard.IsActivated);
        }

        [Fact]
        public void UnblockCardTest()
        {
            var creditCard = new CreditCard(DateTime.Now.AddDays(5), "Igor", "123", 222);
            creditCard.Block();
            Assert.True(creditCard.UnBlock("1234", "1234"));
        }

        [Fact]
        public void ProductEqualsTest()
        {
            var p1 = new HockeyProduct("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "good");
            var p2 = new HockeyProduct("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "good");
            Assert.True(p1 == p2);
        }

        [Fact]
        public void ProductNotEqualsTest()
        {
            var p1 = new HockeyProduct("Stick", "CCM", 1.2, 200, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "good");
            var p2 = new HockeyProduct("Stick", "CCM", 1.2, 100, 200, 20, 2015, "sss", new List<HockeyItemSize>() { HockeyItemSize.Adult, HockeyItemSize.Child },
                "good");
            Assert.True(p1 != p2);
        }
    }
}
