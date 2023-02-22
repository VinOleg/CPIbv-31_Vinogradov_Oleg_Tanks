using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ЦПИбв_31_Виноградов_Олег_Танки.Enum.TankEn;

namespace ЦПИбв_31_Виноградов_Олег_Танки.Controller
{
    public class TankController
    {
        #region ПОЛЯ
        public Entity.Tank Tank { get; set; }
        
        private int _startPosX;
        private int _startPosY;

        private int _pictureWidth = 1250;
        private int _pictureHeight = 550;

        public Image TankImg = Image.FromFile("Img/OurTank.png");
        /// <summary>
        /// Размер в пикселях 1 клетки вверх и вниз
        /// </summary>
        int SizeOneCell = 100;

        protected readonly int _TankWidth = 100;
        protected readonly int _TankHeight = 100;
        #endregion

        public void Init(int speed = 1, int hp = 100, int damage = 25, TypeWeapon typeweapon = TypeWeapon.Cannon, Team team = Team.Enemy)
        {

            Tank = new Entity.Tank();
            Tank.Init(speed, hp, damage, typeweapon, team);
        }
        public void Move(Direction direction)
        {
            //If более компактный и понятный. Свич мало где используется
            if (direction == Direction.Right)
            {
                if (_startPosX + _TankWidth + Tank.Speed * SizeOneCell > _pictureWidth)
                { return; }
                _startPosX += Tank.Speed * SizeOneCell; 
            }
            if (direction == Direction.Left)
            {
                if ( _startPosX == 0)
                { return; }
                _startPosX -= Tank.Speed * SizeOneCell;
            }
            if (direction == Direction.Up)
            {
                if (_startPosY == 0)
                { return; }
                _startPosY -= Tank.Speed * SizeOneCell; 
            }
            if (direction == Direction.Down)
            {
                if (_startPosY + _TankHeight + Tank.Speed * SizeOneCell > _pictureHeight)
                { return; }
                _startPosY += Tank.Speed * SizeOneCell;
            }
            
        }
        public void DrawTank(Graphics g)
        {
            //Замена на растр изображение делает код более компактным
            g.DrawImage(TankImg, _startPosX, _startPosY);
        }
        public void ChangeBorders(int width, int height)
        {
            //Больше ничего и не надо
            _pictureWidth = width;
            _pictureHeight = height;
        }

    }
}
