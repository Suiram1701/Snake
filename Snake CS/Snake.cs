using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    public partial class GUI
    {
        // init Variablen
        private Dir dir = Dir.None;
        private int[][] pos =
        {
            new int[2] {5, 5},
            new int[2] {5, 6}
        };

        /// <summary>
        /// Feld Typen
        /// </summary>
        enum Type
        {
            None,
            Block,
            Food,
            Part,
            Head
        }

        /// <summary>
        /// bewegungs Richtung
        /// </summary>
        enum Dir
        {
            None,
            Top,
            Right,
            Bottom,
            Left
        }

        /// <summary>
        /// In Loop wird alles widerholt
        /// </summary>
        private async void Loop()
        {
            while (true)
            {
                await Task.Run(() =>
                {
                    Update_Pos();

                    // 250ms Verzögerung
                    Thread.Sleep(250);
                });
            }
        }

        /// <summary>
        /// Aktualisiert alle Objekt Positionen
        /// </summary>
        private void Update_Pos()
        {
            // Schlangenteile
            for (int i = pos.Length - 1; i > 0; i--)
            {
                pos[i][0] = pos[i - 1][0];
                pos[i][1] = pos[i - 1][1];
                MoveTo(pos[i][0], pos[i][1], Type.Part);
            }

            //Schlangenkopf
            switch (dir)
            {
                case Dir.Top:
                    pos[0][1]--;
                    break;
                case Dir.Right:
                    pos[0][0]++;
                    break;
                case Dir.Bottom:
                    pos[0][1]++;
                    break;
                case Dir.Left:
                    pos[0][0]--;
                    break;
            }
            MoveTo(pos[0][0], pos[0][1], Type.Head);
        }
    }
}