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
            Loop();
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
                    field.GetControlFromPosition(x, y).BackColor = Color.White;
                    break;
                case Type.Block:
                    field.GetControlFromPosition(x, x).BackColor = Color.Green;
                    break;
                case Type.Food:
                    field.GetControlFromPosition(x, y).BackColor = Color.Yellow;
                    break;
                case Type.Part:
                    field.GetControlFromPosition(x, y).BackColor = Color.Black;
                    break;
                case Type.Head:
                    field.GetControlFromPosition(x, y).BackColor = Color.Red;
                    break;
            }
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
        }
    }
}
