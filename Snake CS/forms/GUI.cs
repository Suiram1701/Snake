using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Setz Farben auf dem Feld.
        /// </summary>
        /// <param name="x">X Koordinate</param>
        /// <param name="y">Y Koordinate</param>
        /// <param name="type"></param>
        private void MoveTo(int x, int y, Type type)
        {
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
    }
}
