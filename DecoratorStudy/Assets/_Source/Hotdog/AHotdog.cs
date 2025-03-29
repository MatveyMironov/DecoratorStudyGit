namespace HotdogSystem
{
    public abstract class AHotdog
    {
        private readonly string _name;

        protected AHotdog(string name)
        {
            _name = name;
        }

        public virtual string GetName()
        {
            return _name;
        }

        public abstract int GetCost();

        public abstract int GetWeight();
    }
}