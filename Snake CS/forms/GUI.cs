using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GUI : Form
    {
        /// <summary>
        /// Neue Benutzeroberfläche
        /// </summary>
        public GUI()
        {
            // init Grafik
            InitializeComponent();

            // Loop
            //Loop();
        }

        /// <summary>
        /// Setzt einen Feld Typ auf ein Feld
        /// </summary>
        /// <param name="x">X Koordinate</param>
        /// <param name="y">Y Koordinate</param>
        /// <param name="type"></param>
        /// <exception cref="ArgumentOutOfRangeException">Beide angegebenen Werte müssen zwischen 0 und 9 liegen.</exception>
        private void MoveTo(int x, int y, Type type)
        {
            // Wenn der Index außerhalb des bereichs liegt
            if (x > 9 || x < 0 || y > 9 || y < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Feld Typ wird gesetzt
            switch (type)
            {
                case Type.None:
                    field.GetControlFromPosition(y, x).BackColor = Color.White;
                    break;
                case Type.Block:
                    field.GetControlFromPosition(y, x).BackColor = Color.Green;
                    break;
                case Type.Food:
                    field.GetControlFromPosition(y, x).BackColor = Color.Yellow;
                    break;
                case Type.Part:
                    field.GetControlFromPosition(y, x).BackColor = Color.Black;
                    break;
                case Type.Head:
                    field.GetControlFromPosition(y, x).BackColor = Color.Red;
                    break;
            }
            field.Refresh();
        }

        /// <summary>
        /// Wenn eine taste gedrückt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GUI_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 38:
                    dir = Dir.Top;
                    break;
                case 39:
                    dir = Dir.Right;
                    break;
                case 40:
                    dir = Dir.Bottom;
                    break;
                case 37:
                    dir = Dir.Left;
                    break;
            }

            Thread.Sleep(1);
        }

        #region Snake Logik
        // init Variablen
        private Dir dir = Dir.None;
        private int[][] pos =
        {
            new int[2] {5, 5},
            new int[2] {5, 6}
        };

        // Feld Typen
        enum Type
        {
            None,
            Block,
            Food,
            Part,
            Head
        }

        // bewegungs Richtung
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
                });

                // 250ms Verzögerung
                Thread.Sleep(250);
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
        }
        #endregion
    }
}
