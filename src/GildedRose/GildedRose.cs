using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private readonly IList<Item> _items;
        private readonly IList<IGildedRoseItem> _gildedRoseItems;

        public GildedRose(IList<Item> items)
        {
            _items = items;
            _gildedRoseItems = new List<IGildedRoseItem>();

            foreach (var item in items)
            {
                _gildedRoseItems.Add(GildedRoseItemFactory.Create(item));
            }
        }

        public void UpdateQuality()
        {
            foreach (var gildedRoseItem in _gildedRoseItems)
            {
                gildedRoseItem.UpdateQuality();
            }
        }
    }
}
