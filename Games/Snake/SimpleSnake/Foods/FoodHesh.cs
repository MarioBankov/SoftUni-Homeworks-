using SimpleSnake.GameObjects;

namespace SimpleSnake.Foods
{
    public class FoodHesh : Food
    {
        private const char foodSymbol = '#';
        private const int points = 3;
        public FoodHesh(Wall wall)
            : base(wall, foodSymbol, points)
        {
        }
    }
}
