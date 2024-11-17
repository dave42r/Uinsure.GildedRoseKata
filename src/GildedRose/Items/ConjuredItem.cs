namespace GildedRoseKata;

public class ConjuredItem : GildedRoseItem
{
    public ConjuredItem(Item item) : base(item) { }

    public override void UpdateQuality()
    {
        DecreaseQuality(2);
        DecreaseSellIn();

        if (Item.SellIn < 0)
        {
            DecreaseQuality(2);
        }
    }
}