
namespace Snake
{
    class Settings2
    {
        public enum Direction2
        {
            Up,
            Down,
            Left,
            Right
        };

        public class Valami
        {
            public static int Width2 { get; set; }
            public static int Height2 { get; set; }
            public static int Speed2 { get; set; }
            public static int Score2 { get; set; }
            public static int Points2 { get; set; }
            public static bool GameOver2 { get; set; }
            public static Direction2 direction2 { get; set; }

            public Valami()
            {
                Width2 = 10;
                Height2 = 10;
                Speed2 = 10;
                Score2 = 0;
                Points2 = 100;
                GameOver2 = false;
                direction2 = Direction2.Down;
            }
        }
    }
}
