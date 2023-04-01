namespace Dragons.Logic
{
    public class Game
    {
        #region Attributes 
        private char[,] _cavern;
        #endregion

        #region Properties 
        public int N { get; }
        public string Way { get; }
        #endregion

        #region Constructors 
        public Game(int n, string way)
        {
            N = n;
            Way = way;
            _cavern = new char[N, (N * 2)];
            PaintCaveOfDeath();
        }


        #endregion

        #region Methots 
        public override string ToString()
        {
            var output = $" ";
            int number = 0;
            int numberF = 0;

            for (int i = 0; i < (N * 2); i++)
            {
                if (i < N)
                {
                    output += $"{number}";
                    number++;
                }
                else
                {
                    output += $"{numberF}";
                    numberF++;
                }
            }
            number = 0;

            output += "\n";
            for (int i = 0; i < N; i++)
            {
                output += i;
                for (int j = 0; j < N * 2; j++)
                {
                    output += $"{_cavern[i, j]}";
                }
                output += "\n";
            }
            return output;
        }
        private void PaintCaveOfDeath()
        {
            PaintEdges();
        }

        private void PaintEdges()
        {
            for (int i = 0; i < (N * 2); i++)
            {
                _cavern[0, i] = '█';
            }

            for (int i = 0; i < (N * 2); i++)
            {
                _cavern[N - 1, i] = '█';
            }

            for (int i = 0; i < N; i++)
            {
                _cavern[i, 0] = '█';
            }

            for (int i = 0; i < N; i++)
            {
                _cavern[i, N * 2 - 1] = '█';
            }

            for (int i = 1; i < N - 1; i++)
            {
                for (int j = 1; j < N * 2 - 1; j++)
                {
                    _cavern[i, j] = ' ';
                }
            }

            _cavern[1, N * 2 - 1] = '█';
            _cavern[1, 0] = ' ';
            _cavern[N - 2, N * 2 - 1] = ' ';
        }
    }

    #endregion

}