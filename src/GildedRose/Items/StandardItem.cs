namespace GildedRoseKata;

public class StandardItem : GildedRoseItem
{
    public StandardItem(Item item) : base(item) { }

    public override void UpdateQuality()
    {
        DecreaseQuality();
        DecreaseSellIn();

        if (Item.SellIn < 0)
        {
            DecreaseQuality();
        }
    }
}