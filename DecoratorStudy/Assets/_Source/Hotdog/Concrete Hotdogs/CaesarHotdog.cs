namespace HotdogSystem
{
    public class CaesarHotdog : AHotdog
    {
        public CaesarHotdog() : base("Caesar Hotdog")
        {
        }

        public override int GetCost()
        {
            return 290;
        }

        public override int GetWeight()
        {
            return 165;
        }
    }
}
