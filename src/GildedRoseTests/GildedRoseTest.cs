using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void StandardItem_QualityDecreasesByOne_BeforeSellInDate()
        {
            var items = new List<Item> { new Item { Name = "Standard Item", SellIn = 10, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(19, items[0].Quality);
            Assert.Equal(9, items[0].SellIn);
        }

        [Fact]
        public void StandardItem_QualityDecreasesTwiceAsFast_AfterSellInDate()
        {
            var items = new List<Item> { new Item { Name = "Standard Item", SellIn = 0, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(18, items[0].Quality);
            Assert.Equal(-1, items[0].SellIn);
        }

        [Fact]
        public void AgedBrie_QualityIncreasesWithTime()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(21, items[0].Quality);
            Assert.Equal(9, items[0].SellIn);
        }

        [Fact]
        public void AgedBrie_QualityIncreasesTwiceAsFast_AfterSellInDate()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(22, items[0].Quality);
            Assert.Equal(-1, items[0].SellIn);
        }

        [Fact]
        public void Sulfuras_QualityAndSellInRemainConstant()
        {
            var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(80, items[0].Quality);
            Assert.Equal(10, items[0].SellIn);
        }

        [Fact]
        public void BackstagePass_QualityIncreasesByOne_WhenMoreThanTenDaysLeft()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(21, items[0].Quality);
            Assert.Equal(14, items[0].SellIn);
        }

        [Fact]
        public void BackstagePass_QualityIncreasesByTwo_WhenTenDaysOrLessLeft()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(22, items[0].Quality);
            Assert.Equal(9, items[0].SellIn);
        }

        [Fact]
        public void BackstagePass_QualityIncreasesByThree_WhenFiveDaysOrLessLeft()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(23, items[0].Quality);
            Assert.Equal(4, items[0].SellIn);
        }

        [Fact]
        public void BackstagePass_QualityDropsToZero_AfterConcert()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
            Assert.Equal(-1, items[0].SellIn);
        }

        [Fact]
        public void ConjuredItem_QualityDecreasesTwiceAsFast_BeforeSellInDate()
        {
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(18, items[0].Quality);
            Assert.Equal(9, items[0].SellIn);
        }

        [Fact]
        public void ConjuredItem_QualityDecreasesTwiceAsFast_AfterSellInDate()
        {
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(16, items[0].Quality);
            Assert.Equal(-1, items[0].SellIn);
        }

        [Fact]
        public void Item_QualityNeverNegative()
        {
            var items = new List<Item> { new Item { Name = "Standard Item", SellIn = 10, Quality = 0 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void Item_QualityNeverMoreThanFifty_ExceptSulfuras()
        {
            var items = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 }
            };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(50, items[0].Quality);
            Assert.Equal(80, items[1].Quality);
        }
    }
}
