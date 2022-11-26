using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private bool foodExist = false;
        private int[] foodPos = new int[2];
        private int score = 0;
        private bool menu = true;

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
                    if (!menu)
                    {
                        SpawnFood();
                        UpdateField();
                        UpdatePos();
                        Collide();
                    }

                    // 250ms Verzögerung
                    Thread.Sleep(250);
                });
            }
        }

        /// <summary>
        /// Erzeugt eine Frucht, wenn keine existiert
        /// </summary>
        private void SpawnFood()
        {
            if (!foodExist)
            {
                Random Rnd = new Random();
                foodPos[0] = Rnd.Next(0, 9);
                foodPos[1] = Rnd.Next(0, 9);

                try { MoveTo(foodPos[0], foodPos[1], Type.Food); }
                catch (ArgumentOutOfRangeException) { Reset(); }
                foodExist = true;
            }
        }

        /// <summary>
        /// Aktualisiert die Felder die nicht besetzt sind
        /// </summary>
        private void UpdateField()
        {
            foreach (int[] p in pos)
            {
                MoveTo(p[0], p[1], Type.None);
            }

            MoveTo(foodPos[0], foodPos[1], Type.Food);
        }

        /// <summary>
        /// Aktualisiert alle Objekt Positionen
        /// </summary>
        private void UpdatePos()
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

        /// <summary>
        /// Erkennt Zusammenstoß
        /// </summary>
        private void Collide()
        {
            for (int i = 1; i < pos.Length - 1; i++)
            {
                if (pos[0][0] == pos[i][0] && pos[0][1] == pos[i][1])
                {
                    Reset();
                }
            }

            if (pos[0][0] == foodPos[0] && pos[0][1] == foodPos[1])
            {
                score++;
                foodExist = false;

                Array.Resize(ref pos, pos.Length + 1);
                pos[pos.Length - 1] = new int[2] { pos[pos.Length - 2][0], pos[pos.Length - 2][1] };
            }
        }

        /// <summary>
        /// Setzt Werte zurückt
        /// </summary>
        public void Reset()
        {
            menu = true;
            Invoke(new Action(() =>
            {
                LoadMenu(true);
            }));
            score = 0;
            dir = Dir.None;
            Array.Resize(ref pos, 0);
            Array.Resize(ref pos, 2);
            pos[0] = new int[2] { 5, 5 };
            pos[1] = new int[2] { 5, 6 };
        }
    }
}