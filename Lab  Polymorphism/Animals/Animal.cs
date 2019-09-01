namespace Animals
{
    public class Animal
    {

       
        public string Name { get; private set; }
        public string FavouriteFood { get; private set; }
        protected Animal(string name, string food)
        {
            this.Name = name;
            this.FavouriteFood = food;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }

    }
}
