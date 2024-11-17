namespace GildedRoseKata;

public class BackstagePass : GildedRoseItem
{
    public BackstagePass(Item item) : base(item) { }

    public override void UpdateQuality()
    {
        if (Item.SellIn > 10)
        {
            IncreaseQuality();
        }
        else if (Item.SellIn > 5)
        {
            IncreaseQuality(2);
        }
        else if (Item.SellIn > 0)
        {
            IncreaseQuality(3);
        }
        else
        {
            Item.Quality = 0;
        }

        DecreaseSellIn();
    }
}