using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Snake.recources;
using System.Diagnostics;

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
            LoadMenu(true);

            // Loop
            Loop();
        }

        /// <summary>
        /// Schlißt das Programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Game Restart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Restart_Click(object sender, EventArgs e)
        {
            score = 0;
            Reset();
        }

        /// <summary>
        /// Setz das Spiel fort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Continue_Click(object sender, EventArgs e)
        {
            menu = false;
            LoadMenu(menu);
        }

        /// <summary>
        /// Setzt einen Feld Typ auf ein Feld
        /// </summary>
        /// <param name="x">X Koordinate</param>
        /// <param name="y">Y Koordinate</param>
        /// <param name="type"></param>
        private void MoveTo(int x, int y, Type type)
        {
            // Wenn der Index außerhalb des bereichs liegt
            if (x > 9 || x < 0 || y > 9 || y < 0)
            {
                Reset();
                return;
            }

            // Feld Typ wird gesetzt
            switch (type)
            {
                case Type.None:
                    field.GetControlFromPosition(x, y).BackgroundImage = null;
                    field.GetControlFromPosition(x, y).BackColor = Color.Snow;
                    break;
                case Type.Block:
                    field.GetControlFromPosition(x, y).BackgroundImage = null;
                    field.GetControlFromPosition(x, x).BackColor = Color.Green;
                    break;
                case Type.Food:
                    field.GetControlFromPosition(x, y).BackgroundImage = null;
                    field.GetControlFromPosition(x, y).BackColor = Color.Yellow;
                    break;
                case Type.Part:
                    field.GetControlFromPosition(x, y).BackgroundImage = null;
                    field.GetControlFromPosition(x, y).BackColor = Color.Black;
                    break;
                case Type.Head:
                    field.GetControlFromPosition(x, y).BackColor = Color.Snow;

                    ComponentResourceManager head = new ComponentResourceManager(typeof(Heads));
                    switch (dir)
                    {
                        case Dir.Top:
                            field.GetControlFromPosition(x, y).BackgroundImage = (Bitmap)head.GetObject("HTop");
                            field.GetControlFromPosition(x, y).BackColor = Color.Snow;
                            break;
                        case Dir.Right:
                            field.GetControlFromPosition(x, y).BackgroundImage = (Bitmap)head.GetObject("HRight");
                            field.GetControlFromPosition(x, y).BackColor = Color.Snow;
                            break;
                        case Dir.Bottom:
                            field.GetControlFromPosition(x, y).BackgroundImage = (Bitmap)head.GetObject("HBottom");
                            field.GetControlFromPosition(x, y).BackColor = Color.Snow;
                            break;
                        case Dir.Left:
                            field.GetControlFromPosition(x, y).BackgroundImage = (Bitmap)head.GetObject("HLeft");
                            field.GetControlFromPosition(x, y).BackColor = Color.Snow;
                            break;
                        default:
                            field.GetControlFromPosition(x, y).BackgroundImage = null;
                            field.GetControlFromPosition(x, y).BackColor = Color.Red;
                            break;
                    }
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
                case 27:
                    if (!menu)
                    {
                        LoadMenu(true);
                        menu = true;
                    }
                    break;
                case 38:
                    if (dir == Dir.Bottom)
                    {
                        break;
                    }
                    dir = Dir.Top;
                    break;
                case 39:
                    if (dir == Dir.Left)
                    {
                        break;
                    }
                    dir = Dir.Right;
                    break;
                case 40:
                    if (dir == Dir.Top)
                    {
                        break;
                    }
                    dir = Dir.Bottom;
                    break;
                case 37:
                    if (dir == Dir.Right)
                    {
                        break;
                    }
                    dir = Dir.Left;
                    break;
            }
        }

        /// <summary>
        /// Change game mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModeChange_Click(object sender, EventArgs e)
        {
            var btn = sender as RadioButton;
            if ((btn.Name == "normal" && isNormal) || (btn.Name == "blocky" && !isNormal)) return;
            isNormal = btn.Name == "normal" ? true : false;

            score = 0;
            cscore.Text = $"Your current score is {score} points!";
            dir = Dir.None;
            Array.Resize(ref pos, 0);
            Array.Resize(ref pos, 2);
            pos[0] = new int[2] { 5, 5 };
            pos[1] = new int[2] { 5, 6 };
        }
    }
}
