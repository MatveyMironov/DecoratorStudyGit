namespace HotdogSystem
{
    public class MeatHotdog : AHotdog
    {
        public MeatHotdog() : base("Meat Hotdog")
        {
        }

        public override int GetCost()
        {
            return 330;
        }

        public override int GetWeight()
        {
            return 188;
        }
    }
}
