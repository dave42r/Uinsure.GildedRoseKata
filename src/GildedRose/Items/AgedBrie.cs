namespace GildedRoseKata;

public class AgedBrie : GildedRoseItem
{
    public AgedBrie(Item item) : base(item) { }

    public override void UpdateQuality()
    {
        IncreaseQuality();
        DecreaseSellIn();

        if (Item.SellIn < 0)
        {
            IncreaseQuality();
        }
    }
}