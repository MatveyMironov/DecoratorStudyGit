namespace HotdogSystem
{
    public class ClassicHotdog : AHotdog
    {
        public ClassicHotdog() : base("Classic Hotdog")
        {
        }

        public override int GetCost()
        {
            return 210;
        }

        public override int GetWeight()
        {
            return 150;
        }
    }
}