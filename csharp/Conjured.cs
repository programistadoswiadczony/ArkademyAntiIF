namespace csharp
{
    public class Conjured : IGood
    {
        public int SellIn { get; set; }

        public void Update(Quality quality)
        {
            quality.Degrade();
            quality.Degrade();
        }
        
        public static IGood Build(int sellIn)
        {
            return sellIn < 0 ? new Expired() : new Generic();
        }

        public class Expired : IGood
        {
            public int SellIn { get; set; }

            public void Update(Quality quality)
            {
                quality.Degrade();
                quality.Degrade();
                quality.Degrade();
                quality.Degrade();
            }
        }
    }
}