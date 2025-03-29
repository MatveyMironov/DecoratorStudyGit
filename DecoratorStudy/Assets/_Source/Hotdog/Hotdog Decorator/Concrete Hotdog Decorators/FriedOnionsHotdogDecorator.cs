namespace HotdogSystem
{
    public class FriedOnionsHotdogDecorator : AHotdogDecorator
    {
        public FriedOnionsHotdogDecorator(AHotdog hotdog) : base(hotdog, " with fried onions")
        {
        }

        public override int GetCost()
        {
            return _hotdog.GetCost() + 30;
        }

        public override int GetWeight()
        {
            return _hotdog.GetWeight() + 10;
        }
    }
}
