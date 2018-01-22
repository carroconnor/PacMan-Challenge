namespace Italian
{
    public class Pacman
    {
        public int Points { get; set; }
        public int Lives { get; set; }

        public Pacman()
        {
            Points = 5000;
            Lives = 3;
        }

        public int GetPoints()
        {
            return this.Points;
        }

        public void AddPoints(int points)
        {
            this.Points = this.Points + points;
        }

        public int GetLives()
        {
            return this.Lives;
        }

        public void SubtractLives(int lives)
        {
            this.Lives = this.Lives - lives;
        }

        public void AddLife()
        {
            this.Lives = this.Lives + 1;
        }
    }
}
