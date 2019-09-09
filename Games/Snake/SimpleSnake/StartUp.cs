namespace SimpleSnake
{
    using NAudio.Wave;
    using SimpleSnake.Core;
    using SimpleSnake.GameObjects;
    using Utilities;
    

    public class StartUp
    {
        public static void Main()
        {

            ConsoleWindow.CustomizeConsole();
            Wall wall = new Wall(30, 20);
            Score score = new Score();
            Snake snake = new Snake(wall,score);
            Engine engine = new Engine(wall, snake);
            engine.Run();
        }
    }
}
