using System.Collections.Generic;
using System.IO;

namespace Italian
{
    public class GameService  //IGameServices
    {
        public List<string> GameSequence;


        public int SequenceIndex = 0;

        //check to see if we add points, subtract lives, add lives
        public void ProcessCurrentItem(Pacman pacman)
        {
            var currentGameObject = new GameObject(this.GameSequence[this.SequenceIndex]);

            pacman.AddPoints(currentGameObject.GetPoints());

            pacman.SubtractLives(currentGameObject.GetLives());

            this.SequenceIndex = this.SequenceIndex + 1;
        }

        //Get Access to svc file
        public void ReadGameSequenceFile()
        {
            using (var reader = new StreamReader(@"C:\Users\carro\source\repos\Italian\Italian\KataPacman-seq.txt"))
            {
                List<string> Sequence = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    for (int i = 0; i < values.Length; i++)
                    {
                        Sequence.Add(values[i]);
                    }
                }

                this.GameSequence = Sequence;

            }
        }
    }
}
