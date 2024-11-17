using System;

namespace GildedRoseKata;

public abstract class GildedRoseItem : IGildedRoseItem
{
    protected Item Item;

    protected GildedRoseItem(Item item)
    {
        Item = item;
    }

    public abstract void UpdateQuality();

    protected void DecreaseSellIn()
    {
        Item.SellIn--;
    }

    protected void DecreaseQuality(int amount = 1)
    {
        Item.Quality = Math.Max(0, Item.Quality - amount);
    }

    protected void IncreaseQuality(int amount = 1)
    {
        Item.Quality = Math.Min(50, Item.Quality + amount);
    }
}