namespace GildedRoseKata;

public class Sulfuras : GildedRoseItem
{
    public Sulfuras(Item item) : base(item) { }

    public override void UpdateQuality()
    {
        // Sulfuras never changes in quality or sell-in value.
    }
}