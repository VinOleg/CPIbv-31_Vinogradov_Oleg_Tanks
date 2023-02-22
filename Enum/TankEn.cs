using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЦПИбв_31_Виноградов_Олег_Танки.Enum
{
    /// <summary>
    /// Все Enum для танка. Вывел в отдельный файл чтобы было удобнее работать и добавлять.
    /// </summary>
    public class TankEn
    {

        /// <summary>
        /// Тип пушки в данный момент
        /// </summary>
        public enum TypeWeapon
        {
            /// <summary>
            /// Пулемет
            /// </summary>
            MachineGun,
            /// <summary>
            /// Пушка
            /// </summary>
            Cannon,
            /// <summary>
            /// дробовик
            /// </summary>
            Shotgun
        }

        /// <summary>
        /// Тип команды
        /// </summary>
        public enum Team
        {
            /// <summary>
            /// Танк игрока
            /// </summary>
            Our,
            /// <summary>
            /// Дружественный танк 
            /// </summary>
            Frendly,
            /// <summary>
            /// Враг
            /// </summary>
            Enemy
        }

        /// <summary>
        /// Направление перемещения
        /// </summary>
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }
    }
}
