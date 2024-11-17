namespace GildedRoseKata
{
    public static class GildedRoseItemFactory
    {
        public static IGildedRoseItem Create(Item item)
        {
            return item.Name switch
            {
                "Aged Brie" => new AgedBrie(item),
                "Sulfuras, Hand of Ragnaros" => new Sulfuras(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePass(item),
                string name when name.StartsWith("Conjured") => new ConjuredItem(item),
                _ => new StandardItem(item)
            };
        }
    }
}