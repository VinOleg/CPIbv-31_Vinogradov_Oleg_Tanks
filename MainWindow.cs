using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЦПИбв_31_Виноградов_Олег_Танки.Controller;
using ЦПИбв_31_Виноградов_Олег_Танки.Entity;

namespace ЦПИбв_31_Виноградов_Олег_Танки
{
    public partial class MainWindow : Form
    {
        private TankController _tankController;
        /// <summary>
        /// Лист всех танков на будущее
        /// </summary>
        public List<Tank> tanks = new List<Tank>();
        public MainWindow()
        {
            InitializeComponent();
        }
        #region BUTTONS
        private void ButtonNewGame_Click(object sender, EventArgs e)
        {
            tanks.Clear();
            Random rnd = new Random();
            _tankController = new TankController();

            _tankController.Init();
            toolStripStatusLabelSpeed.Text = $"Скорость: {_tankController.Tank.Speed} Клеток в ход (будут ускорять бонусы)";
            Draw();
        }
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if(_tankController == null)
            { return; }
            string name = ((Button)sender)?.Name ?? string.Empty; switch (name)
            {
                case "buttonUp":
                    _tankController?.Move(Enum.TankEn.Direction.Up);
                    break;
                case "buttonDown":
                    _tankController?.Move(Enum.TankEn.Direction.Down);
                    break;
                case "buttonLeft":
                    _tankController?.Move(Enum.TankEn.Direction.Left);
                    break;
                case "buttonRight":
                    _tankController?.Move(Enum.TankEn.Direction.Right);
                    break;
            }
            Draw();
        }
    #endregion
    private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            Graphics gr = Graphics.FromImage(bmp);

            #region MAP
            Pen p = new Pen(Color.Black);
            for(int i = 0; i <= pictureBoxMain.Width / 100; i++)
            { 
                gr.DrawLine(p, new Point(i * 100, 0), new Point(i * 100, pictureBoxMain.Width));
                
                for (int j = 0; j <= pictureBoxMain.Height / 100; j++)
                {
                    gr.DrawLine(p, new Point(0, i * 100), new Point(pictureBoxMain.Width, i * 100));
                }
            }

            #endregion
            _tankController.DrawTank(gr);
            pictureBoxMain.Image = bmp;
        }
        private void pictureBoxMain_SizeChanged(object sender, EventArgs e)
        {
            _tankController.ChangeBorders(pictureBoxMain.Width, pictureBoxMain.Height); 
            Draw();

        }
    }
}
