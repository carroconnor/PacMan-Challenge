using System;

namespace Italian
{
    public class GameController
    {
        private static GameService game = new GameService();

        public Pacman pacman = new Pacman();

        public void Start()
        {
            game.ReadGameSequenceFile();

            for (int i = 0; i < game.GameSequence.Count; i++)
            {
                game.ProcessCurrentItem(this.pacman);
            }

            Console.WriteLine(this.pacman.GetPoints());
            Console.WriteLine(this.pacman.GetLives());
            Console.ReadLine();
        }

        public static void ReadFile()
        {
            game.ReadGameSequenceFile();
        }
    }
}
