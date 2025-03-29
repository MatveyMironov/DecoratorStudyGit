namespace HotdogSystem
{
    public abstract class AHotdogDecorator : AHotdog
    {
        protected readonly AHotdog _hotdog;

        public AHotdogDecorator(AHotdog hotdog, string name) : base(hotdog.GetName() + name)
        {
            _hotdog = hotdog;
        }
    }
}
