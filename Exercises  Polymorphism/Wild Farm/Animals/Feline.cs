namespace Wild_Farm.Animals
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight,  string region,string breeed)
            : base(name, weight,  region)
        {
            this.Breed = breeed;
        }
        public string Breed { get; protected set; }
        public override string ToString()
        {
            return base.ToString() + $"{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }

}
