namespace Wild_Farm.Animals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight,  string region) 
            : base(name, weight)
        {
            this.LivingRegion = region;
        }
        public string LivingRegion { get; private set; }
    }
}
