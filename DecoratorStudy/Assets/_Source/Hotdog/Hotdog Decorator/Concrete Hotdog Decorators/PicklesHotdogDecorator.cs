namespace HotdogSystem
{
    public class PicklesHotdogDecorator : AHotdogDecorator
    {
        public PicklesHotdogDecorator(AHotdog hotdog) : base(hotdog, " with pickles")
        {
        }

        public override int GetCost()
        {
            return _hotdog.GetCost() + 50;
        }

        public override int GetWeight()
        {
            return _hotdog.GetWeight() + 20;
        }
    }
}
